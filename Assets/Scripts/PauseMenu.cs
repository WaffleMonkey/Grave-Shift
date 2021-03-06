using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           
            if (!GameIsPaused)
            {
               Pause();
            }
        }
        /* else if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            QuitGame();
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
           LoadMenu();
        } */



    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // put it back to normal game
        GameIsPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Debug.Log("ResumeClicked");
    }
     void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // freeze game
        GameIsPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("Paused");
    }
    public void LoadMenu()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("StartMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
