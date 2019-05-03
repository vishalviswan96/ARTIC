using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
{
    public GameObject destroyedBox;

    public void TakeDamage()
    {
        Debug.Log("Taking Damage");
        Instantiate(destroyedBox, transform.position, transform.rotation);
        Destroy(gameObject, 0.1f);
       
    }

}
