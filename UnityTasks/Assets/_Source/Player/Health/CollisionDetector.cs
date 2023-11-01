using System;
using UnityEngine;

namespace Player.Health
{
    public class CollisionDetector : MonoBehaviour
    {
        private Health _health;

        public void Constructor(Health health)
        {
            _health = health;
        }
        private void OnTriggerEnter(Collider other)
        {
            _health.AddHp(10);
        }
    }
}
