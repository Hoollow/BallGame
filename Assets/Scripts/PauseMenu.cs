using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool GamePause = false;


    public GameObject pauseMenuUI;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) //Wiadomo
        {
            if(GamePause)
            {
                Resume();
               
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false); //ui znika
        Time.timeScale = 1f; //Gra leci dalej
        GamePause = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true); //Ui pojawia sie
        Time.timeScale = 0f; //Pauzujemy gre
        GamePause = true;
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f; //Gra leci dalej
    }   
    public void QuitGame()
    {
        Application.Quit();
    }

}
