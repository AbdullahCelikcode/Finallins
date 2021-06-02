using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fare : MonoBehaviour
{

    public float moueSensivity = 50;
    public Transform playerBody;
    float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * moueSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * moueSensivity * Time.deltaTime;


        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
