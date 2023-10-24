using System;
using ShootSystem;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private CharacterShooter characterShooter;
        private void Update()
        {
            if (Input.GetKey(KeyCode.S))
            {
                characterShooter.Shoot();
            }
        }
    }
}
