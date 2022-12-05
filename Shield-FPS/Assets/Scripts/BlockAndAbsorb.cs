using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockAndAbsorb : MonoBehaviour
{
    public LayerMask collisionLayer;
    public float radius = 1f;
    public float energy = 5f;

    void Update()
    {
        DetectCollision();
    }
    void DetectCollision()
    {
        Collider[] hit = Physics.OverlapSphere(transform.position, radius, collisionLayer);
        if (hit.Length > 0)
        {
            energy++;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
