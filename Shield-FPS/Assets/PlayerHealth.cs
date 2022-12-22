using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float currentHealth = 100f;
    public float maxHealth = 100f;
    public float healthRegenRate = 1.0f; 
    private CharacterAnimation animationScript;
    public Image bloodyScreen;
    private bool characterDied;

    void Awake()
    {

        animationScript = GetComponentInChildren<CharacterAnimation>();

    }
    private void Update()
    {
        BloodOverlay();
        if(currentHealth < 100f)
        {
            RegenerateHealth();
        }
    }
    void BloodOverlay()
    {
        // Calculate the percentage of health remaining
        float healthPercent = currentHealth / maxHealth;

        // Use the healthPercent value to smoothly interpolate the color of the bloodyScreen image
        Color bloodyColor = Color.Lerp(Color.red, Color.clear, healthPercent);
        bloodyScreen.color = bloodyColor;
    }
    void RegenerateHealth()
    {
         currentHealth += healthRegenRate * Time.deltaTime;
         
    }
    public void ApplyDamage(float damage)
    {
        if (characterDied)
            return;

        currentHealth -= damage; 
       //animationScript.PlayerHurt();

        if (currentHealth <= 0f)
        {
            animationScript.Death();
            characterDied = true;
        }

    }
}
