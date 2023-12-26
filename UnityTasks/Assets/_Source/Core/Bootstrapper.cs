using System;
using BulletSystem;
using ShootSystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private CharacterShooter characterShooter;
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private int maxPoolSize;
        [SerializeField] private int startPoolSize;
        private ObjectPool _objectPool;

        private void Awake()
        {
            StartGame();
        }

        private void StartGame()
        {
            _objectPool = new ObjectPool(bulletPrefab, maxPoolSize, startPoolSize);
            _objectPool.Init();
            characterShooter.Construct(_objectPool);
        }
    }
}
