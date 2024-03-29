using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Declare a variable
   
    private int scoreCount = 0; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore(int points) 
    {
        // Add points score 
        scoreCount += points;
    }
    public void DecreaseScore(int points) 
    {
        // Ensure score does not go below zero
        if (scoreCount - points >= 0)
        {
            scoreCount -= points;
        }
        else
        {
            scoreCount = 0;
        }
    }

    public int GetScore() 
    {
        return scoreCount; 
    }

}
