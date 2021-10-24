using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class GameManager : MonoBehaviour
{
    public float time=25;
    public Text timer;
    public bool game_over,game_win;

    public GameObject Remote;
    public Transform[] Spawn_Positions;

    public GameObject Win_canvas;
    public GameObject Pause_Canvas;
    public GameObject Game_Over_Canvas;

    public GameObject Explosion1;
    public GameObject Explosion2;

    private bool trigger_alarm = true;

    private void Awake()
    {
        Time.timeScale = 1f;
        game_win = false;
        game_over = false;
        Spawn_Remote();
    }


    private void Start()
    {
        FindObjectOfType<audiomanager>().play("Level_Music");
    }

    private void Spawn_Remote()
    {
        Vector3 v = Spawn_Positions[Random.Range(0, Spawn_Positions.Length)].position;
        Instantiate(Remote,v,Quaternion.identity);
    }

    private void Update()
    {   if (time > 0)
            time -= Time.deltaTime;
        else
        {
            if(!game_win)
                StartCoroutine(Game_Over());
        }
            

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }

        if (time < 20 && trigger_alarm)
        {
            FindObjectOfType<audiomanager>().play("Alarm_Sound");
            trigger_alarm = false;
        }
        Display_Time();
    }

    

    public void Display_Time()
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        timer.text = string.Format("{0:00}:{1:00}",minutes,seconds);
    }

    IEnumerator Game_Over()
    {
        game_over = true;
        Explosion1.SetActive(true);
        Explosion2.SetActive(true);
        yield return new WaitForSecondsRealtime(2f);
        Time.timeScale = 0f;
        Game_Over_Canvas.SetActive(true);
        
    }

    public void Game_win()
    {
        game_win = true;
        Time.timeScale = 0.5f;
        Win_canvas.SetActive(true);
    }

     public void Pause()
    {
        Time.timeScale = 0f;
        Pause_Canvas.SetActive(true);
    }

}
