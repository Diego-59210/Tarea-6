using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 1.5f;
    public float smoothing = 1.5f;
    private float mousePosX;
    private float smoothedMousePos;

    private float currentLookingPos;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        GetInput();
        ModifyInput();
        MovePlayer();
    }
    void GetInput()
    {
        mousePosX = Input.GetAxisRaw("Mouse X");
    }
    void ModifyInput()
    {
        mousePosX *= sensitivity * smoothing;
        smoothedMousePos = Mathf.Lerp(smoothedMousePos, mousePosX, 1f / smoothing);
    }
    void MovePlayer()
    {
        currentLookingPos += smoothedMousePos;
        transform.localRotation = Quaternion.AngleAxis(currentLookingPos, transform.up);
    }
}