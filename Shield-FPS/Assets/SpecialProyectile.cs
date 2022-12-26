using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialProyectile : MonoBehaviour
{
    
    public float radius = 3f;
    public float damage = 20f;
    public float force = 4f;
    public LayerMask collisionLayer;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 localDirection = new Vector3(0, 0, 1);
        Vector3 worldDirection = transform.TransformDirection(localDirection);
        Fire(worldDirection, force);
    }

    // Update is called once per frame
    void Update()
    {
        DetectCollision();
    }
    void Fire(Vector3 direction, float force)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(direction * force, ForceMode.Impulse);       
    }
    void DetectCollision()
    {
        Collider[] hit = Physics.OverlapSphere(transform.position, radius, collisionLayer);
        if (hit.Length > 0)
        {
            hit[0].GetComponent<HealthScript>().ApplyDamage(damage);
            gameObject.SetActive(false);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
