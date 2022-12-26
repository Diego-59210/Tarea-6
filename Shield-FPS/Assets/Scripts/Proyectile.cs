using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectile : MonoBehaviour
{
    public float speed = 3f;
    public float damage = 15f;
    public float energyAmount = 20f;
    public float radius;
    public LayerMask collisionLayer1;
    public LayerMask collisionLayer2;
    private Transform target;
    

    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }
    void Update()
    {
        // calculate the distance to the target
        float distance = Vector3.Distance(transform.position, target.position);

        // move the projectile towards the target
        transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
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
