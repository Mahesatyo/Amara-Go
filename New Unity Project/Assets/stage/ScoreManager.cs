using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public float scoreCount;
    public float pointsPerSecond;
    public bool scoreIncreasing;
    //private float score;

    // Update is called once per frame
    void Update()
    {
        if(scoreIncreasing)
        {
        scoreCount += pointsPerSecond * Time.deltaTime;
        }

        scoreText.text = " " + Mathf.Round(scoreCount);


        /*if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }*/
        
    }

    public void AddScore(int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }
}
