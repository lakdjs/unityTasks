using System;
using UnityEngine;

namespace BulletSystem
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private float lifeTime;
        private float curLifeTime;

        private void Awake()
        {
            curLifeTime = lifeTime;
        }

        void Update()
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            curLifeTime -= Time.deltaTime;
            if (curLifeTime <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
