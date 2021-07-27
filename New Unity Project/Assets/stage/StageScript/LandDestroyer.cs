using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandDestroyer : MonoBehaviour
{
    public GameObject landDestructionPoint;

    void Start()
    {
        landDestructionPoint = GameObject.Find ("LandDestructionPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < landDestructionPoint.transform.position.x)
        {
            gameObject.SetActive(false);
        }
    }
}
