using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProyectile : MonoBehaviour
{

    public Transform shootingPoint;

    public GameObject proyectilePrefab;

    private bool isShooting;

    void Update()
    {
        
    }
    void ShootArrow()
    {
        if (isShooting)
        {
          Instantiate(proyectilePrefab, shootingPoint.position, shootingPoint.rotation);
        }  
    }

}
