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
        alphaColor.a += .1f;
        bloodScreen.color = alphaColor;
    }
    public void RegainHealth()
    {
        alphaColor.a -= .1f;
        bloodScreen.color = alphaColor;
    }
}
