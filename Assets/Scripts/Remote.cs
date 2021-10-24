using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Remote : MonoBehaviour
{

    private GameManager _Game_Manager;

    private void Awake()
    {
        _Game_Manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (SceneManager.GetActiveScene().name == "AREA 51")
            {

            }
            else
            {
                if (!_Game_Manager.game_over)
                    _Game_Manager.Game_win();
            }

            Destroy(gameObject);
        }
    
    }


}
