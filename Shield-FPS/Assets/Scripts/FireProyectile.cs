using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProyectile : MonoBehaviour
{

    public Transform shootingPoint;

    public GameObject proyectilePrefab;

    private bool canShoot;

    private void Start()
    {
        StartCoroutine(ShootPrefab());
    }
    IEnumerator ShootPrefab()
    {
        canShoot = true;
        yield return new WaitForSeconds(5);
        if(canShoot == true)
        {
            Instantiate(proyectilePrefab, shootingPoint.position, shootingPoint.rotation);
        }
        canShoot = false;
    }

}
