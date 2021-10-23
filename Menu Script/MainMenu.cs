using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public CinemachineBrain mainCamera;
    public CinemachineVirtualCamera frame0_cam;
    public CinemachineVirtualCamera frame1_cam;
    public CinemachineVirtualCamera frame2_cam;

    public GameObject aboutPanel;
    public GameObject helpPanel;

    public GameObject[] frame;
    public GameObject startButton;
    public EventSystem ES;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && frame[0].activeInHierarchy)
        {
            frame[0].SetActive(false);
            frame[1].SetActive(true);
            ES.SetSelectedGameObject(startButton);
            frame0_cam.gameObject.SetActive(false);
            frame1_cam.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && !frame[0].activeInHierarchy)
        {
            frame[1].SetActive(false);
            frame[2].SetActive(false);
            frame[0].SetActive(true);
            frame1_cam.gameObject.SetActive(false);
            frame2_cam.gameObject.SetActive(false);
            frame0_cam.gameObject.SetActive(true);
        }
    }

    public void StartButton()
    {
        SceneManager.LoadScene("");
    }

    public void About()
    {
        if (aboutPanel!= null)
        {
            bool isActive = aboutPanel.activeSelf;
            aboutPanel.SetActive(!isActive);
        }
    }

    public void Help()
    {
        if(helpPanel!= null)
        {
            bool isActive = helpPanel.activeSelf;
            helpPanel.SetActive(!isActive);
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
