using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandGenerator : MonoBehaviour
{
    public GameObject theLand;
    public Transform generationPoint;
    public float distanceBetween;

    private float landWidth;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    //public GameObject[] theLands;

    private int landSelector;

    private float[] landWidths;
    public ObjectPooler[] theObjectPools;

    private float minHeight;
    public Transform maxHeightPoint;
    private float maxHeight;
    public float maxHeightChange;
    private float heightChange;

    private InfectGenerator theInfectGenerator;
    public float randomCoinThreshold;

    void Start()
    {
        //landWidth = theLand.GetComponent<BoxCollider2D>().size.x;

        landWidths = new float[theObjectPools.Length];

        for(int i = 0; i < theObjectPools.Length; i++)
        {
            landWidths[i] = theObjectPools[i].pooledObject.GetComponent<BoxCollider2D>().size.x;
        }

        minHeight = transform.position.y;
        maxHeight = maxHeightPoint.position.y;

        theInfectGenerator = FindObjectOfType<InfectGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < generationPoint.position.x)
        {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            landSelector = Random.Range(0, theObjectPools.Length);

            heightChange = transform.position.y + Random.Range(maxHeightChange, -maxHeightChange);

            if(heightChange > maxHeight)
            {
                heightChange = maxHeight;
            } else if(heightChange < minHeight)
            {
                heightChange = minHeight;
            }

            transform.position = new Vector3(transform.position.x + (landWidths[landSelector] / 2) + distanceBetween, heightChange, transform.position.z);

            //Instantiate(/*theLand*/theLands[landSelector], transform.position, transform.rotation);


            GameObject newLand = theObjectPools[landSelector].GetPooledObject();

            newLand.transform.position = transform.position;
            newLand.transform.rotation = transform.rotation;
            newLand.SetActive(true);

            if(Random.Range(0f, 100f) < randomCoinThreshold)
            {
            theInfectGenerator.SpawnInfects(new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z));
            }
            transform.position = new Vector3(transform.position.x + (landWidths[landSelector] / 2), transform.position.y, transform.position.z);
        }
    }
}
