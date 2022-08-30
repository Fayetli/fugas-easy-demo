using UnityEngine;

namespace Fugas.Demo.Movement
{
    public class PlayerMovement : MonoBehaviour
    {
        public CharacterController2D controller;
        public float runSpeed = 40f;
        public Transform startPoint;

        private float horizontalMove = 0f;
        private bool jump = false;

        private void Update()
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            if(Input.GetKeyDown(KeyCode.Space))
            {
                jump = true;
            }
        }


        private void FixedUpdate()
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
            jump = false;
        }

        public void ResetPosition()
        {
            transform.position = startPoint.position;
        }
    }
}