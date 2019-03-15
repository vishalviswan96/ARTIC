using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	
	void Start () {
		
	}
	
	void Update () {
        //forward
        transform.Translate(Vector3.forward * Time.deltaTime *0.9f);
        //face camera
        transform.LookAt(Camera.main.transform.position);
        //rotation
        transform.eulerAngles = new Vector3(0,transform.eulerAngles.y,0);
	}
}
