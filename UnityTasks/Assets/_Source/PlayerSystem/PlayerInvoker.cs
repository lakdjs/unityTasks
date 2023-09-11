using UnityEngine;

namespace PlayerSystem
{
    public class PlayerInvoker
    {
        private PlayerMovement _playerMovement;
        private Player _player;
        public PlayerInvoker(Player player)
        {
            _player = player;
            _playerMovement = new PlayerMovement();
        }

        public void Move(Vector3 moveDirection)
        {
            _playerMovement.Move(_player.Rb,_player.MovementSpeed,moveDirection);
        }

        public void Rotate(float x, float z)
        {
            _playerMovement.Rotate(x,z, _player.Rb, _player.RotationSpeed,_player.transform);
        }

        public void Jump()
        {
            _playerMovement.Jump(_player.Rb, _player.JumpForce);   
        }
    }
}
