using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinternaScript : MonoBehaviour
{
    public GameObject lightSource;
    public AudioSource lightSound;
    public bool isOn = false;
    public bool failsafe = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(isOn == false && failsafe == false)
            {
                failsafe = true;
                lightSource.SetActive(true);
                //lightSound.Play();
                isOn = true;
                StartCoroutine(Failsafe());
            }
            if (isOn == true && failsafe == false)
            {
                failsafe = true;
                lightSource.SetActive(false);
                //lightSound.Play();
                isOn = false;
                StartCoroutine(Failsafe());
            }
        }


    }
    IEnumerator Failsafe()
    {
        yield return new WaitForSeconds(0.25f);
        failsafe = false;
    }

}
