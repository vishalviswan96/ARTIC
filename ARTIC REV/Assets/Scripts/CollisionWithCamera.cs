using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Collision  With Camera Script
public class CollisionWithCamera : MonoBehaviour {

    public bool zombieIsThere;
    float timer;
    float timeBetweenAttack;
    AudioSource attackSound;

    //set ref to other script
    private GameControllerScript gameController;


	// Use this for initialization
	void Start () {
       
        //intervel bw zombie attack
        timeBetweenAttack = 1f;

        //find gameobj with tag 
       GameObject gameControllerObject = GameObject.FindWithTag("GameController");

        if(gameControllerObject != null)
        {
            //gets gamecontroller script
            gameController = gameControllerObject.GetComponent<GameControllerScript>();
        }

        AudioSource[] audio = GetComponents<AudioSource>();
        attackSound = audio[0];

	}
	
	// Update is called once per frame
	void Update () {
        //counter
        timer += Time.deltaTime;


        if (zombieIsThere && timer >= timeBetweenAttack)
        {
            Attack();
        }
		
	}
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "MainCamera")
        {
            zombieIsThere = true;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "MainCamera")
        {
            zombieIsThere = false;
        }
    }
    void Attack()
    {
        timer = 0f;
        //animator access
        GetComponent<Animator> ().Play ("attack");

       // calling gamecontroller script
        gameController.zombieAttack (zombieIsThere);

        attackSound.Play();

    }

   
}
