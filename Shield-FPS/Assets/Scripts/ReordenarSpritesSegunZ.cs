using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ReordenarSpritesSegunZ : MonoBehaviour
{

    SortingGroup sg;

    private void Start()
    {
        sg = GetComponent<SortingGroup>();
    }
    private void Update()
    {
        sg.sortingOrder = (int)(transform.position.z * 1000);
    }
}
