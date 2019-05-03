using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//enemy Shooting Script
public class ShootEnemy : MonoBehaviour {

 
    public Button shootButton;
    public Camera fpsCamera;
    public float damage = 35f;
    public GameObject bloodEffect;
    public GameObject shootingEffect;
    public int forceAdd = 200;
   
    public AudioSource reloadSound;
    public Text ammo1Text;
    public Text ammo2Text;
    public int ammo1;
    public int ammo2;
    private bool ammoIsEmpty;
    private bool reloadCheck;
    
	// Use this for initialization
	void Start () {

      //  audioManager = GameObject.FindObjectOfType<AudioManager>();
        AudioSource audio = GetComponent <AudioSource>();
     
        shootButton.onClick.AddListener(OnShoot);
      
        ammo1 = 20;
        ammo2 = 200;
        reloadCheck = true;
	}

   

    IEnumerator WaitForReload()
    {
        //wait 3 sec and continue OnShoot
        yield return new WaitForSeconds(3f);
        reloadCheck = true;
    }

    // Update is called once per frame
    void OnShoot ()
    {
        //increment ammo by 20 after each round 
        if (!ammoIsEmpty && reloadCheck)
        {
            if (ammo1 == 1)
            {
                ammo1 = 21;
                //checking the reload after 20 bullets
                reloadCheck = false;
                //coroutine for reload
                StartCoroutine(WaitForReload());
                //AudioManager.instance.ReloadSound();
                reloadSound.Play();
            }

            // text to string
            ammo1 -= 1;
            string ammo1String = (ammo1).ToString();
            ammo1Text.text = ammo1String;

            ammo2 -= 1;
            string ammo2String = (ammo2).ToString();
            ammo2Text.text = "/ " + ammo2String;
            AudioManager.instance.ShootSound();
            //shootSound.Play();

            //if ammo2 zero empty magzin overwrit ammo 1 string
            if (ammo2 == 0)
            {
                ammoIsEmpty = true;
                ammo1 = 0;
                string ammo11String = (ammo1).ToString();
                ammo1Text.text = ammo11String;
            }

            RaycastHit hit;
            //raycasting to shoot gmobj
            if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit))
            {
                Debug.Log(hit.transform.name);

                //link with enemy script
                Enemy target = hit.transform.GetComponent<Enemy>();
                if (target != null)
                {
                    target.takeDamage(damage);
                    GameObject bloodTempObj = Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
                    Destroy(bloodTempObj, 0.1f);
                }
                else
                {
                    GameObject shootTempObj = Instantiate(shootingEffect, hit.point, Quaternion.LookRotation(hit.normal));
                    Destroy(shootTempObj, 0.1f);
                }
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(-hit.normal * forceAdd);
                }
            }
        }
        
    

    }
}
