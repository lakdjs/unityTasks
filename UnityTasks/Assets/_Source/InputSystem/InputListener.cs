using System;
using Player.Movement;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";
        private Movement _movement;
        private Vector3 _direction;

        public void Constructor(Movement movement)
        {
            _movement = movement;
        }

        private void FixedUpdate()
        {
            ReadMove();
        }

        private void ReadMove()
        {
            float horizontal = Input.GetAxis(Horizontal);
            float vertical = Input.GetAxis(Vertical);
            Vector3 moveDir = new Vector3(horizontal, vertical);
            _movement.Move(moveDir);
        }
    }
}
