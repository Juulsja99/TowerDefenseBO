using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateMenu : MonoBehaviour
{
    public GameObject menuUi;


    public void PlayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");

    }

   public void Stop()
    {
        Application.Quit();
    }
}
