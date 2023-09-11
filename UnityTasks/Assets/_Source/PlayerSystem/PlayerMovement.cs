using UnityEngine;

namespace PlayerSystem
{
    public class PlayerMovement 
    {
        public void Move(Rigidbody rb, float speed, Vector3 moveDirection)
        {
            Vector3 velocity = moveDirection * speed;
            rb.velocity = new Vector3(velocity.x, rb.velocity.y, velocity.z);
        }

        public void Rotate(float x, float z, Rigidbody rb, float speed, Transform transform)
        {
            Vector3 rot = new Vector3(x, 0f, z)*speed;
            rb.MoveRotation(Quaternion.LookRotation(rot));
        }

        public void Jump(Rigidbody rb, float force)
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
