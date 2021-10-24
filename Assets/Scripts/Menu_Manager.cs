using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Manager : MonoBehaviour
{
    public void Resume()
    {
        Time.timeScale = 1f;
        FindObjectOfType<GameManager>().Pause_Canvas.SetActive(false);
    }
    public void Back()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void exit()
    {
        Application.Quit();
    }

    public void tutorial()
    {
        SceneManager.LoadScene("AREA 51");
    }

    public void Level_1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Level_2()
    {
        SceneManager.LoadScene("Level_2");
    }

    public void Mission()
    {
        SceneManager.LoadScene("Mission");
    }

}
