using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestruct : MonoBehaviour
{
    private bool bombaActiva = true;
    public GameObject explosion;
    public float temporizador = 0f;
    public float tiempoLimite = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        if (bombaActiva)
        {
            if (temporizador >= tiempoLimite)
            {
                Destroy(this.gameObject, t: 0);
                explosion.SetActive(true);
                bombaActiva = false;
            }    
        }      temporizador += Time.deltaTime;
        
    }
}
