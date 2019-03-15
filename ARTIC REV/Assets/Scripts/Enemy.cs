using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float health = 100f;
    AudioSource bloodSound;
    public int killCounter = 1 ;
    

	// Use this for initialization
	void Start () {
     
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

        KillCounter.counter += killCounter;
        Destroy(gameObject, 0f);
       
    }
}
