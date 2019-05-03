using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioScript : MonoBehaviour
{
    private AudioManager audioManager;
    public Button musicToggleButton;
    public Sprite musicOn;
    public Sprite musicOff;

    private void Start()
    {
        audioManager = GameObject.FindObjectOfType<AudioManager>();
        UpdateIcon(); 
    }
    public void PauseMusic()
    {
        audioManager.ToggleSound();
        UpdateIcon();
    }

    void UpdateIcon()
    {
        if(PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            AudioListener.volume = 1;
            musicToggleButton.GetComponent<Image>().sprite = musicOn;
        }
        else
        {
            AudioListener.volume = 0;
            musicToggleButton.GetComponent<Image>().sprite = musicOff;
        }
    }
}
