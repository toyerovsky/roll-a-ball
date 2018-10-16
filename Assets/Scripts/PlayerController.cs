using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public float Speed;

        private Rigidbody rigidbody;

        public void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
        }

        public void FixedUpdate()
        {
            float horizontalAxis = Input.GetAxis("Horizontal");
            float verticalAxis = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontalAxis, 0, verticalAxis);

            rigidbody.AddForce(movement * Speed);
        }
    }
}
