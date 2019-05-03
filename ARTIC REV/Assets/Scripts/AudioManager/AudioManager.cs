using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Audio Manager Script

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance = null;
    [SerializeField]
    private AudioSource soundFx;
    [SerializeField]
    private AudioClip shootClip, buttonClickClip, timesUp;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);

        }
    }
    public void ShootSound()
    {
        soundFx.clip = shootClip;
        soundFx.Play();
    }
    public void ButtonClickSound()
    {
        soundFx.clip = buttonClickClip;
        soundFx.Play();
    }
    public void TimesUp()
    {
        soundFx.clip = timesUp;
        soundFx.Play();
    }

    public void ToggleSound()
    {
        if(PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            PlayerPrefs.SetInt("Muted", 1);

        }
        else
        {
            PlayerPrefs.SetInt("Muted", 0);
        }
    }
}
