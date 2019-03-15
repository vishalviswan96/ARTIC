using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadNewGame : MonoBehaviour {

    //ref of button
    public Button newGame;

	// Use this for initialization
	void Start () {
      //  newGame.onClick.AddListener(LoadGame);
		
	}
	
	public void LoadGame () {

        SceneManager.LoadScene("StartScene");
	}
}
