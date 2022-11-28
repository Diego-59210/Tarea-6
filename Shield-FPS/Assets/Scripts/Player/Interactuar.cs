using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactuar : MonoBehaviour
{
    AudioSource RejaSonido;
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
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("AbrirReja", true);
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            anim.SetBool("AbrirReja", false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("Interactuar", true);
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            anim.SetBool("Interactuar", false);
        }




    }
}