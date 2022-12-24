using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public LayerMask collisionLayer1;
    public LayerMask collisionLayer2;
    public float radius = 1f;
    public float damage = 2f;
    public float energyAmount = 2f;

    void Update()
    {
        DetectCollision();
    }
    void DetectCollision()
    {
        Collider[] hitShield = Physics.OverlapSphere(transform.position, radius, collisionLayer1);
        if (hitShield.Length > 0)
        {
            hitShield[0].GetComponentInParent<CharacterAnimation>().BlockedAttack();
            hitShield[0].GetComponentInParent<SpecialAttack>().AbsorbPower(energyAmount);
            gameObject.SetActive(false);
        }
        Collider[] hitPlayer = Physics.OverlapSphere(transform.position, radius, collisionLayer2);
        if (hitPlayer.Length > 0)
        {
            hitPlayer[0].GetComponent<PlayerHealth>().ApplyDamage(damage);                         
            gameObject.SetActive(false);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
