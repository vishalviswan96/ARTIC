using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//loading NewGame Script
public class LoadNewGame : MonoBehaviour {

    public Text highScoreText;
    public Text killsText;
   // public static int counter;

    //ref of button
    public GameObject newGame;

	// Use this for initialization
	void Start () {
        
        highScoreText.text = "HIGHSCORE : " + PlayerPrefs.GetInt("HighScore").ToString();
        killsText.text = "KILLS : " + PlayerPrefs.GetInt("KillCount", 0).ToString();
    }
    

    public void LoadGame () {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
       
	}
}
