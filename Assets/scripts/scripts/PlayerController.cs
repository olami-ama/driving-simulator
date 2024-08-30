using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private float speed = 20.0f;
   private float turnSpeed = 45.0f;
   private float horizontalInput;
   private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame (it is called 50 to 60 time)
    void Update()
    {
      // move the vehicle forward and adds control to move left and right
      //transform.Translate(0,0,1);  is the same as vector3
      // this is where we get user input
      horizontalInput = Input.GetAxis("Horizontal");
      forwardInput = Input.GetAxis("Vertical");
      // moves the car forward based on vertical input
      transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
      // Rotates the car based on hortizontal input
      transform.Rotate(Vector3.up ,  Time.deltaTime *horizontalInput * turnSpeed  );
    }
}
