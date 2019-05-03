using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAmmo : MonoBehaviour
{

    public GameObject pickUpButton;
    public GameObject CrossHair;


    // Use this for initialization
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "mag")
        {
            pickUpButton.gameObject.SetActive(true);
            CrossHair.gameObject.SetActive(false);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "mag")
        {
            pickUpButton.gameObject.SetActive(false);
            CrossHair.gameObject.SetActive(true);
        }
    }
   
}
