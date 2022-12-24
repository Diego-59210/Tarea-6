using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public float health = 100f;
    private CharacterAnimation animationScript;
    private EnemyMovement enemyScript;

    private bool characterDied;

    public bool isEnemy, isWall;


    void Awake()
    {
        animationScript = GetComponentInChildren<CharacterAnimation>();
       
        
        if(isEnemy)
        {
            enemyScript = GetComponent<EnemyMovement>();
        }
        
    }

    public void ApplyDamage(float damage)
    {
        if (characterDied)
            return;
        
        health -= damage;

        if (isWall)
        {
            Debug.Log("Wall Hit");
        }
        if (isEnemy)
        {
            animationScript.EnemyHit();
        }

        if (health <= 0f)
        {
            animationScript.Death();
            characterDied = true;

            if(isEnemy)
            {
                enemyScript.enabled = false;
                
            }
            return;
            
        }
 
        
    }
}
