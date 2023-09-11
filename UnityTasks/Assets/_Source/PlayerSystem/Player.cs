using UnityEngine;

namespace PlayerSystem
{
    [RequireComponent(typeof(Rigidbody))]
    public class Player : MonoBehaviour
    {
        [field: SerializeField] public float MovementSpeed { get; private set; }
        [field: SerializeField] public float RotationSpeed { get; private set; }
        [field: SerializeField] public float JumpForce { get; private set; }
        [field: SerializeField] public Rigidbody Rb { get; private set; }
        public bool OnGround { get; private set; }
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.name == "Ground")
            {
                OnGround = true;
            }
        }

        private void OnCollisionExit(Collision other)
        {
            if (other.gameObject.name == "Ground")
            {
                OnGround = false;
            }
        }
    }
}
