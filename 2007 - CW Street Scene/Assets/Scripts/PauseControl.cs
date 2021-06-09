using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseControl : MonoBehaviour
{
    public static bool pauseGame;
    public static bool gameOver;
    public GameObject GameUI, PauseUI;
    public GameObject car;
    public GameObject carEngine;
    public Button UIResumeBtn;
    

    // Update is called once per frame
    void Update()
    {
        //if escape is pressed pause the game
        if (Input.GetKeyDown(KeyCode.Escape) || UIResumeBtn.GetComponent<UIResumeButton>().clicked)
        {
            UIResumeBtn.GetComponent<UIResumeButton>().clicked = false;
            pauseGame = !pauseGame;
            PauseGameControl();
        }
        if (car.GetComponent<TimeRemaining>().alarm)
        {
            gameOver = true;
            StopGame();
        }
    }
    void PauseGameControl()
    {
        if (pauseGame)
        {
            Time.timeScale = 0f;
            GameUI.SetActive(false);
            PauseUI.SetActive(true);
            car.GetComponent<AudioSource>().Pause();
            carEngine.GetComponent<AudioSource>().Pause();
        }
        else
        {
            Time.timeScale = 1;
            GameUI.SetActive(true);
            PauseUI.SetActive(false);
            car.GetComponent<AudioSource>().Play();
            carEngine.GetComponent<AudioSource>().Play();
        }
    }

    void StopGame()
    {
        Time.timeScale = 0f;
        car.GetComponent<AudioSource>().Stop();
        carEngine.GetComponent<AudioSource>().Stop();
    }
}
