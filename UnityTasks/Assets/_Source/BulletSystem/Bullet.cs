using System;
using UnityEngine;

namespace BulletSystem
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private float lifeTime;
        private float curLifeTime;
        private ObjectPool _owner;

        private void OnEnable()
        {
            curLifeTime = lifeTime;
        }

        public void SetOwner(ObjectPool objectPool)
        {
            _owner = objectPool;
        }
        void Update()
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            curLifeTime -= Time.deltaTime;
            if (curLifeTime <= 0)
            {
                _owner.ReturnToPool(gameObject);
            }
        }
    }
}
