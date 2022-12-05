using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AttackUniversal : MonoBehaviour
{
    public LayerMask collisionLayer;
    public float radius = 1f;
    public float damage = 2f;

    public bool isPlayer, isEnemy;
    
    void Update()
    {
        DetectCollision();
    }
    void DetectCollision()
    {
        Collider[] hit = Physics.OverlapSphere(transform.position, radius, collisionLayer);
        if(hit.Length > 0)
        {
            if(isPlayer)
            {
                hit[0].GetComponent<HealthScript>().ApplyDamage(damage);   
            }
            if(isEnemy)
            {
                
                hit[0].GetComponent<HealthScript>().ApplyDamage(damage);
                
            }
            gameObject.SetActive(false);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
