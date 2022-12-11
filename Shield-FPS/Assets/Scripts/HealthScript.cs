using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public float health = 100f;
    private CharacterAnimation animationScript;
    private EnemyMovement enemyMovement;

    private bool characterDied;

    public bool isPlayer, isEnemy;

    private HealthUI healthUI;

    void Awake()
    {
        animationScript = GetComponentInChildren<CharacterAnimation>();
       
        if (isPlayer)
        {
            //healthUI = GetComponent<HealthUI>();
        }
        if(isEnemy)
        {
            enemyMovement = GetComponent<EnemyMovement>();
        }
        
    }
    public void ApplyDamage(float damage)
    {
        if (characterDied)
            return;
        
        health -= damage;

        if(isPlayer)
        {
            //animationScript.PlayerHurt();
            //healthUI.DisplayHealth(health);
        }

        if(health <= 0f)
        {
            animationScript.Death();
            characterDied = true;

            if(isEnemy)
            {
                enemyMovement.enabled = false;
                transform.gameObject.layer = 0;
            }

            if(isPlayer)
            {
                GameObject.FindWithTag("Enemy").GetComponent<EnemyMovement>().enabled = false;
            }
            return;
            
        }
        
        if (!isPlayer)
        {
            animationScript.EnemyHit();
        }
        
    }  
}
