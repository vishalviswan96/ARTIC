using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCounter : MonoBehaviour {

    public static int counter;
    Text text;

	void Start () {

        //reference
        text = GetComponent<Text>();
        //reset
        counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
        //Text property of text component
        text.text = "KILLS: " + counter;
	}
}
