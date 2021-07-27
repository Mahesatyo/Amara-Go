using System.Collections;
using UnityEngine;

public class pickupPoints : MonoBehaviour
{
    public int scoreToGive;
    private ScoreManager theScoreManager;
    
    private AudioSource infectSound;

    void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();

        infectSound = GameObject.Find("WhenCuring").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "1")
        {
            //theScoreManager.scoreCount += scoreToGive;
            theScoreManager.AddScore(scoreToGive);

            gameObject.SetActive(false);

            if(infectSound.isPlaying)
            {
                infectSound.Stop();
                infectSound.Play();
            } 
            else
            {
                infectSound.Play();
            }

            
        }
    }
}
