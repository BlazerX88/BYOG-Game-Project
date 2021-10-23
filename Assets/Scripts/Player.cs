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
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Player_rb.velocity = new Vector3(inputX*speed, 0, inputY*speed);
        
    }
}
