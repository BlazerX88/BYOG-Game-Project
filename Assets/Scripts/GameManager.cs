using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class GameManager : MonoBehaviour
{
    public float time=60;
    public Text timer;
    private bool game_over,game_win;

    public GameObject Remote;
    public Transform[] Spawn_Positions;

    private void Awake()
    {
        game_win = false;
        game_over = false;
        Spawn_Remote();
        
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
            Game_Over(); 

        Display_Time();
    }

    

    public void Display_Time()
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        timer.text = string.Format("{0:00}:{1:00}",minutes,seconds);
    }

    private void Game_Over()
    {
        game_over = true;
        Time.timeScale = 0f;
        throw new NotImplementedException();
    }

}
