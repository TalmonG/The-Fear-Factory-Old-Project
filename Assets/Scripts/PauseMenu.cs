using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject progresslost;
    public bool isPaused;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused == false)
            {
                Pause();
                isPaused = true;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Debug.Log("You paused the game");
            }
            else
            {
                Resume();
                isPaused = false;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                Debug.Log("You resumed the game");
            }
        }
    }

    void Start()
    {
        pauseMenu.SetActive(false);
        progresslost.SetActive(false);
        isPaused = false;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(false);
        progresslost.SetActive(true);
    }

    public void NoQuit()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        progresslost.SetActive(false);
    }

    public void YesQuit()
    {
        Time.timeScale = 1f;
        Debug.Log("QUIT!");
        Application.Quit();
    }
}