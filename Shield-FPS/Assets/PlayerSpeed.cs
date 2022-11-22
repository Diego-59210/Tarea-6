using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpeed : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim.SetBool("CorrerPlayer", true);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            anim.SetBool("CorrerPlayer", false);
        }

        


    }
}
