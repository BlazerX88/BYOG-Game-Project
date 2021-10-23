using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody Player_rb;

    private float speed=4;

    // Start is called before the first frame update
    void Start()
    {
        Player_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void Update()
    {
        Movement_Input();
        Up_And_Down();
    }

    private void Up_And_Down()
    {
       
       if(Input.GetKey(KeyCode.I))
            Player_rb.velocity = Vector3.up*speed;
        if (Input.GetKey(KeyCode.K))
            Player_rb.velocity = Vector3.down*speed;
       
        
    }

    private void Movement_Input()
    {
        float inputY = Input.GetAxis("Vertical");
        float inputX = Input.GetAxis("Horizontal");

        Player_rb.velocity = transform.forward * speed * inputY;
        transform.Rotate(Vector3.up * inputX * Time.deltaTime * 90);
    }
}
