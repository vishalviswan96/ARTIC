using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudios : MonoBehaviour
{
    private AudioManager audioManager;
    
    void Start()
    {
        audioManager = GameObject.FindObjectOfType<AudioManager>(); 
    }

    public void PlayClickSound()
    {
        audioManager.ButtonClickSound();
    }

    public void PlayShootSound()
    {
        audioManager.ShootSound();
    }
}
