using System;
using System.Collections.Generic;
using UnityEngine;

namespace BulletSystem
{
    public class ObjectPool
    {
         private GameObject _bulletPrefab;
         private int _maxPoolSize;
         private int _startPoolSize;
         private int _count;
        private List<GameObject> _bullets;
        private List<GameObject> _bulletsUnderControl;

        public ObjectPool(GameObject bulletPrefab, int poolSize, int startPoolSize)
        {
            _bulletPrefab = bulletPrefab;
            _maxPoolSize = poolSize;
            _startPoolSize = startPoolSize;
        }
        public void Init()
        {
            _bullets = new List<GameObject>();
            _bulletsUnderControl = new List<GameObject>();
            for (int i = 0; i < _startPoolSize; i++)
            {
                GameObject bulletInstance = MonoBehaviour.Instantiate(_bulletPrefab);
                if (bulletInstance.TryGetComponent(out Bullet bullet))
                {
                    bullet.SetOwner(this);
                }
                bulletInstance.SetActive(false);
                _bullets.Add(bulletInstance);
            }
        }
        
        public bool TryGetFromPool(out GameObject bulletInstance)
        {
            bulletInstance = null;
            if (_bullets.Count > 0)
            {
                bulletInstance = _bullets[0];
                bulletInstance.SetActive(true);
                _bullets.RemoveAt(0);
                _bulletsUnderControl.Add(bulletInstance);
                _count++;
                return true;
            }
            if(_bullets.Count == 0)
            {
                GameObject newBulletInstance = MonoBehaviour.Instantiate(_bulletPrefab);
                if (newBulletInstance.TryGetComponent(out Bullet bullet))
                {
                    bullet.SetOwner(this);
                }
                _bullets.Add(newBulletInstance);
                TryGetFromPool(out bulletInstance);
            }
            return false;
        }

        public void ReturnToPool(GameObject bulletInstance)
        {
            bulletInstance.SetActive(false);
            _bullets.Add(bulletInstance);
            _bulletsUnderControl.RemoveAt(0);
            _count--;
        }
    }
}