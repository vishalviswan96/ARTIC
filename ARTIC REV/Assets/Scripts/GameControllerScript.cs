using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour {

    public GameObject BloodScreen;
    public Text healthText;
    public int health;
    

    // Use this for initialization
    void Start () {

        health = 100;
	}

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
            
        }

    }


    public void zombieAttack(bool ZombieIsThere)
    {
        //display blood screen
        BloodScreen.gameObject.SetActive(true);

        //coroutine to stap zombie attack for some sec
        StartCoroutine(Wait2seconds());
        health -= 20;

        //int to string 
        string stringHealth = (health).ToString();
        healthText.text = "" + stringHealth;
    }

    //collection of related const
    IEnumerator Wait2seconds()
    {
        //wait 2 sec
        yield return new WaitForSeconds(2f);
        //set bolld screen fase in 2 sec
        BloodScreen.gameObject.SetActive(false);
    }



}
