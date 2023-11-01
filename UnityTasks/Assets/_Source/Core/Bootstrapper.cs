using System;
using InputSystem;
using Player;
using Player.Health;
using Player.Movement;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private HealthView healthView;
        [SerializeField] private MovementView movementView;
        [SerializeField] private InputListener inputListener;
        [SerializeField] private int hp;
        [SerializeField] private Rigidbody playerRigidbody;
        [SerializeField] private float speed;
        [SerializeField] private CollisionDetector collisionDetector;
        private Health _health;
        private HealthController _healthController;
        private Movement _movement;
        private MovementController _movementController;
        
        private void Awake()
        {
            StartGame();
        }

        private void StartGame()
        {
            _movement = new Movement(speed, playerRigidbody);
            _movementController = new MovementController(_movement, movementView);
            _movementController.Bind();
            _health = new Health(hp);
            _healthController = new HealthController(_health, healthView);
            _healthController.Bind();
            _health.StartHp();
            inputListener.Constructor(_movement);
            collisionDetector.Constructor(_health);
        }
    }
}
