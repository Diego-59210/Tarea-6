using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObject : MonoBehaviour
{
    private bool ObjetoActivado = true;
    public GameObject objeto;
    public float temporizador = 0f;
    public float tiempoLimite = 0f;
    void Start()
    {

    }

    void Update()
    {
        if (ObjetoActivado)
        {
            if (temporizador >= tiempoLimite)
            {
                
                tiempoLimite = 0f;
                ObjetoActivado = false;
                objeto.SetActive(true);
            }
        }
        temporizador += Time.deltaTime;

    }

    
}
