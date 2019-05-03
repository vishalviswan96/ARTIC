using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//CountDown Timer Script
public class CountDownTimer : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 90f;
    public GameObject Timer;

    [SerializeField] Text countDownText;


    private void Start()
    {
        currentTime = startingTime;
        Timer.gameObject.SetActive(true);
        
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");
        if(currentTime <= 0)
        {
            currentTime = 0;
            GameOver();
        }
    }
    public void GameOver()
    {
        AudioManager.instance.TimesUp();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
