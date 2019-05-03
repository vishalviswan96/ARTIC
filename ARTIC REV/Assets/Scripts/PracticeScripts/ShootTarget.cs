using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootTarget : MonoBehaviour
{
    public Button shootButton;
    public Camera fpsCamera;
    public GameObject shootingEffect;
    public int addForce = 700;
    // Start is called before the first frame update
    void Start()
    {
        shootButton.onClick.AddListener(OnShoot);  
    }

    void OnShoot()
    {
        
        RaycastHit hit;
        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit))
        {
           
            Destructable destruct = hit.transform.GetComponent<Destructable>();
            TargetBehaviour target = hit.transform.GetComponent<TargetBehaviour>();

            if (target != null)
            {
                target.TakeDamage();
            }
            else if(destruct != null)
            {
                destruct.TakeDamage();
            }

            else
            {
                GameObject shoot = Instantiate(shootingEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(shoot, 0.1f);
            }

            if (hit.rigidbody != null)
            {

                hit.rigidbody.AddForce(hit.normal * addForce);
            }
        }
    }
}
