using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimations : MonoBehaviour
{

    Animator anim;
    Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        tr = transform;
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("Caminar", true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("Caminar", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("Caminar", true);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("Caminar", false);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("Caminar", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("Caminar", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("Caminar", true);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("Caminar", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim.SetBool("Correr", true);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            anim.SetBool("Correr", false);
        }


    }
}
