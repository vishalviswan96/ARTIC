using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnController : MonoBehaviour {

    public GameObject zombie;
    public Button varifiedButton;

    // Use this for initialization
    void Start () {

        varifiedButton.onClick.AddListener(StartInvoke);

    }
	
	public void StartInvoke() {

        //repete in each sec(method, start time, spawn intervel)
        InvokeRepeating("Spawn", 5f, 2f);
	}

    void Spawn()
    {
        //random position of enemy
        Vector3 position = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
        
        //generate obj, pos, rotation of enemy
        Instantiate(zombie, position, Quaternion.Euler(0, 0, 0));
    }
}
