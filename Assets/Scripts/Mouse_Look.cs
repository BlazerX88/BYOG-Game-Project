using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Look : MonoBehaviour
{

    private float Mouse_Sensitivity=100f;

    private Transform playerBody;

    float xRotation = 0f;

    private void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Mouse_Sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Mouse_Sensitivity * Time.deltaTime;

        xRotation -= mouseX;
        xRotation = Mathf.Clamp(xRotation, 90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
