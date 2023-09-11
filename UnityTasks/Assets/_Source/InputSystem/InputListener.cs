using System;
using PlayerSystem;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private KeyCode jumpKey;
        [SerializeField] private Player player;
        private PlayerInvoker _playerInvoker;
        private bool _isInputOn;

        private void Awake()
        {
            _playerInvoker = new PlayerInvoker(player);
        }

        private void Update()
        {
            if (_isInputOn)
            {
                ReadMove();
                ReadRotate();
                ReadJumpKey();
            }
            ReadOffInputKey();
            ReadOnInput();
        }
        private void ReadRotate()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            _playerInvoker.Rotate(horizontal, vertical);
        }
        private void ReadMove()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            
            Vector3 moveDirection = new Vector3(horizontal, 0f, vertical );
            
            _playerInvoker.Move(moveDirection);
        }
        private void ReadJumpKey()
        {
            if (Input.GetKeyDown(jumpKey)&&player.OnGround)
            {
                _playerInvoker.Jump();
            }
        }
        private void ReadOffInputKey()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                _isInputOn = false;
            }
        }
        private void ReadOnInput()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _isInputOn = true;
            }
        }
    }
}
