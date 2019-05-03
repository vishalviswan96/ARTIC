using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{


    public void TakeDamage()
    {
        Destroy(gameObject, 2f);
    }

    
    

}
