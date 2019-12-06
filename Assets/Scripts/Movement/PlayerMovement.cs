using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Movement
{
    public class PlayerMovement : MonoBehaviour
    {
        //Rigidbody2D rb;
        [SerializeField] float moveSpeed = 1;

        void Start()
        {
            //rb = GetComponent<Rigidbody2D>();   
        }

        void Update()
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
                transform.Translate(Vector2.right * moveSpeed);
            else if (Input.GetAxisRaw("Horizontal") < 0)
                transform.Translate(Vector2.left * moveSpeed);
        }

        private void FixedUpdate()
        {
            //characterController.Move(horizontalMove);
        }
    }
}