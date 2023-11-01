using System;
using UnityEngine;

namespace Player.Movement
{
    public class Movement
    {
        public event Action<Vector3> OnMoving; 
        private float _speed;
        private Rigidbody _rigidbody;
        
        public Movement(float speed, Rigidbody rigidbody)
        {
            _speed = speed;
            _rigidbody = rigidbody;
        }

        public void Move(Vector3 moveDir)
        {
            Vector3 velocity = moveDir * _speed;
            _rigidbody.velocity = new Vector2(velocity.x, velocity.y);
            OnMoving?.Invoke(moveDir);
        }
    }
}
