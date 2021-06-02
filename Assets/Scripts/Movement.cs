using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 16;
    Vector3 velocity;
    public float gravity =-9.81f;
    public CharacterController controller;
    public Transform groundCheck;
    public float gorundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpHeight=3f;
    bool isGrounded;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded=Physics.CheckSphere(groundCheck.position,gorundDistance,groundMask);
            if (isGrounded && velocity.y <0 )
            {
                velocity.y=-2f;
            }
         if (isGrounded && Input.GetKey(KeyCode.LeftShift))
        {
            speed = 10;


        }
        else speed = 16;
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
       
        Vector3 move = transform.right * x + transform.forward * z;
       
        controller.Move(move * 10 * Time.deltaTime);
       
        if (Input.GetButtonDown("Jump")&& isGrounded)
        {
            velocity.y=Mathf.Sqrt(jumpHeight*-2f*gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

}
