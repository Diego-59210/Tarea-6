using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    public LayerMask detectLayer;
    private GameObject thisObject;
    private EnemyAttack enemyScript;
    // Start is called before the first frame update
    void Start()
    {
        thisObject = gameObject;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(LayerMask.LayerToName(other.gameObject.layer) == detectLayer.ToString())
        {
            enemyScript = GetComponent<EnemyAttack>();
            enemyScript.enabled = true;
        }
    }

}
