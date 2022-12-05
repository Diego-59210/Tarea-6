using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 20f;
    public float momentumDamping = 5f;
    private CharacterController playerController;

    private Vector3 inputVector;
    private Vector3 movementVector;

    //public Animator camAnim;
    //private bool isWalking;

    private float gravity = -10;

    void Start()
    {
        playerController = GetComponent<CharacterController>();
    }

    void Update()
    {
        PlayerInput();
        MovePlayer();  

        //camAnim.SetBool("isWalking", isWalking);
    }
    void PlayerInput()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            inputVector = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
            inputVector.Normalize();
            inputVector = transform.TransformDirection(inputVector);

            //isWalking = true;
        }
        else
        {
            inputVector = Vector3.Lerp(inputVector, Vector3.zero, momentumDamping * Time.deltaTime);

            //isWalking = false;
        }

        movementVector = (inputVector * playerSpeed) + (Vector3.up * gravity);
    }
    void MovePlayer()
    {
        playerController.Move(movementVector * Time.deltaTime);
    }
  


}
