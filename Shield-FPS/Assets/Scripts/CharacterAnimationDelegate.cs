using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationDelegate : MonoBehaviour
{
    public GameObject AttackPoint;
    private Collider enemyCollider;
    public GameObject proyectilePrefab;
    public Transform shootingPoint;

    private EnemyMovement enemyMovementScript;

    void Awake()
    {
        if (gameObject.CompareTag("Enemy"))
        {
            enemyMovementScript = GetComponentInParent<EnemyMovement>();
        }
    }
    void SpecialAttackProyectile()
    {
        Instantiate(proyectilePrefab, shootingPoint.position, shootingPoint.rotation);
    }
    void AttackON()
    {
        AttackPoint.SetActive(true);
    }
    void AttackOFF()
    {
        if (AttackPoint.activeInHierarchy)
        {
            AttackPoint.SetActive(false);
        }
    }
    
    void DisableMovement()
    {
        enemyMovementScript.enabled = false;
        transform.parent.gameObject.layer = 0;
    }
    void EnableMovement()
    {
        enemyMovementScript.enabled = true;
        transform.parent.gameObject.layer = 7;
    }
    void CharacterDeath()
    {
        Invoke("DeactivateGameObject", 2f);
    }
    void DeactivateGameObject()
    {
        enemyCollider = GetComponentInParent<CapsuleCollider>();
        enemyCollider.enabled = false; 
        gameObject.SetActive(false);
    }
}
