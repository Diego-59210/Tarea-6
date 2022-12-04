using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Image bloodScreen;
    Color alphaColor;

    // Start is called before the first frame update
    void Awake()
    {
        alphaColor = bloodScreen.color;
    }

    public void DisplayHealth(float value)
    {
        value /= 100f;

        if (value < 0f)
        {
            value = 0f;
        }
        alphaColor.a += .25f;
        bloodScreen.color = alphaColor;
    }
}
