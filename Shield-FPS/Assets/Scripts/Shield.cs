using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Blocking();
    }

    void Blocking()
    {
        if(Input.GetKey(KeyCode.Mouse1))
        {
            anim.SetBool("Blocking", true);
        }
        else if(Input.GetKeyUp(KeyCode.Mouse1))
        {
            anim.SetBool("Blocking", false);
        }
    }

}
