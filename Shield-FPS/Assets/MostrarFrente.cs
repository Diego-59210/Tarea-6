using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarFrente : MonoBehaviour
{
    public Renderer r;
    public int sortOrder;
    public string sortLayer;

    private void Start()
    {
        r = GetComponent<Renderer>();
    }
    // Update is called once per frame
    void Update()
    {
        r.sortingOrder = sortOrder;
        r.sortingLayerName = sortLayer;
    }
}
