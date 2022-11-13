using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 20f;
    private CharacterController playerController;

    private Vector3 inputVector;
    private Vector3 movementVector;

    private float gravity = -10;

    void Start()
    {
        playerController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
        MovePlayer();
    }
    void PlayerInput()
    {
        inputVector = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        inputVector.Normalize();
        inputVector = transform.TransformDirection(inputVector);

        movementVector = (inputVector * playerSpeed) + (Vector3.up * gravity);
    }
    void MovePlayer()
    {
        playerController.Move(movementVector * Time.deltaTime);
    }
    
}
