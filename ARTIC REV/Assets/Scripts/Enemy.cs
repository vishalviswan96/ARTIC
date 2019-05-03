using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Enemy Script
public class Enemy : MonoBehaviour {

    public ScoreManager scoreManager;
    public float health = 100f;
    AudioSource bloodSound;
    public int killCounter = 1 ;
    

	// Use this for initialization
	void Start () {

        // scoreManager = GameObject.FindWithTag("ScoreManager").GetComponent<ScoreManager>();
        scoreManager = FindObjectOfType<ScoreManager>();
            AudioSource[] audio = GetComponents<AudioSource>();
        bloodSound = audio [1];
        
    }
	
    
    public void takeDamage(float damage)
    {
        bloodSound.Play();
        health -= damage;
        print(health);
        
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        GetComponent<Animator>().Play("fallingback");
        scoreManager.IncrementScore();
        Destroy(gameObject, 0.4f);
       
    }
}
