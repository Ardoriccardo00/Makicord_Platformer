using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D characterController;
    float horizontalMove = 0;
    void Start()
    {
        
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        //characterController.Move(horizontalMove);
    }
}
