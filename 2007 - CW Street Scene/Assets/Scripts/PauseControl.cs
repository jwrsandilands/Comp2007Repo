using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour
{
    public static bool pauseGame;
    public GameObject GameUI, PauseUI;

    // Update is called once per frame
    void Update()
    {
        //if escape is pressed pause the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseGame = !pauseGame;
            PauseGameControl();
        }
    }
    void PauseGameControl()
    {
        if (pauseGame)
        {
            Time.timeScale = 0f;
            GameUI.SetActive(false);
            PauseUI.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            GameUI.SetActive(true);
            PauseUI.SetActive(false);
        }
    }
}
