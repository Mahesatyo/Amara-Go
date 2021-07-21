using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandGenerator : MonoBehaviour
{
    public GameObject theLand;
    public Transform generationPoint;
    public float distanceBetween;

    private float landWidth;
    void Start()
    {
        landWidth = theLand.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + landWidth + distanceBetween, transform.position.y, transform.position.z);

            Instantiate(theLand, transform.position, transform.rotation);
        }
    }
}
