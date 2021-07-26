using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectGenerator : MonoBehaviour
{
    public ObjectPooler infectPool;
    public float distancebetweenInfects;
    
    public void SpawnInfects (Vector3 startPosition)
    {
        GameObject infect1 = infectPool.GetPooledObject();
        infect1.transform.position = startPosition;
        infect1.SetActive(true);
    }
}
