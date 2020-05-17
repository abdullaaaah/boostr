using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float thrustSpeed;
    public float rotationSpeed;
    private Rigidbody rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        detectRocketThrust();
        detectRotation();
    }

    private void detectRocketThrust()
    {
        Vector3 thrustForce = new Vector3(0f, (thrustSpeed * Time.deltaTime) , 0f);
        if (CrossPlatformInputManager.GetButton("Fire"))
        {
            rigidBody = GetComponent<Rigidbody>();
            rigidBody.AddRelativeForce(thrustForce);
            print("thrust pressed");
        }
    }

    private void detectRotation()
    {
        float xMovement = CrossPlatformInputManager.GetAxis("Horizontal");
        rigidBody.angularVelocity = Vector3.zero; // remove rotation due to physics
        float rotationThisFrame = rotationSpeed * Time.deltaTime;

        if (xMovement>0f)
        {
            transform.Rotate(-(Vector3.forward * rotationThisFrame));
            print("right pressed " + xMovement);
        }
        else if(xMovement<0f)
        {
            transform.Rotate((Vector3.forward * rotationThisFrame));
            print("left pressed" + xMovement);
        }
        
    }

}
