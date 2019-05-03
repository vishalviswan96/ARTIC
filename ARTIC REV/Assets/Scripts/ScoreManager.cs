using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Score Managr Script
public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
   // public Text highScoreText;

    public int scoreCount;
    public int highScoreCount;

    private void Awake()
    {
        PlayerPrefs.DeleteKey("KillCount");
    }
    void Start()
    {
        scoreCount = 0;
       // PlayerPrefs.DeleteKey("KillCount");
         if(PlayerPrefs.GetInt("HighScore") != null)
         {
             PlayerPrefs.GetInt("HighScore");
         }
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncrementScore()
    {
        scoreCount++;
        PlayerPrefs.SetInt("KillCount", scoreCount);

        if(scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
            PlayerPrefs.SetInt("HighScore", highScoreCount);
        }

        scoreText.text = "KILLS: " + scoreCount;
       // highScoreText.text = "HIGHSCORE: " + highScoreCount;
    }
}
