using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image bloodScreen;
    public Slider healthBar;
    public float health = 50;
    public float healthRegenerationRate = 1f;
    private float maxHealth;
    Color alphacolor;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
        healthBar.maxValue = maxHealth;
        alphacolor = bloodScreen.color;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = health;
       
    }
    public void DisplayDamage()
    {
        if (health < 0)
            health--;
        //health -= damage;
        alphacolor.a += .01f;
        bloodScreen.color = alphacolor;

    }
    public void RegenerateHealth()
    {
           health += healthRegenerationRate * Time.deltaTime;
           alphacolor.a -= .01f;
           bloodScreen.color = alphacolor;

    }
}
