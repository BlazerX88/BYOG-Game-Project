using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenuUI;
    [SerializeField] private bool isPaused;


    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused =! isPaused;
        }

        if(isPaused)
        {
            ActivateMenu();
        }
        else
        {
            Resume();
        }
    }


    void ActivateMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        PauseMenuUI.SetActive(true);

    }

    public void Resume()
    {
        
        Time.timeScale = 1;
        PauseMenuUI.SetActive(false);
        isPaused = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
