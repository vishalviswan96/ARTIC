using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
    public Button varifiedButton;
    private PlaceOnPlane placeOnPlane;
    public GameObject CrossHair;
    public Button Cancel;
    public GameObject startGame;
    public GameObject shootButton;
    public Camera fpsCamera;


    // Use this for initialization
    void Start () {

        varifiedButton.onClick.AddListener(StartNewGame);
        Cancel.onClick.AddListener(CancelBack);
		
	}
	
	
	public void StartNewGame ()
    {
        
        placeOnPlane = GetComponent<PlaceOnPlane>();
        Destroy(placeOnPlane);

        startGame.gameObject.SetActive(false);
        //varifiedButton.gameObject.SetActive(false);
        //Cancel.gameObject.SetActive(false);
        CrossHair.gameObject.SetActive(true);
        shootButton.gameObject.SetActive(true);

    }

    public void CancelBack()
    {
        SceneManager.LoadScene("Menu");
    }
}
