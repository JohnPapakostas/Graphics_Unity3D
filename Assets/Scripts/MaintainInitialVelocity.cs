using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaintainInitialVelocity : MonoBehaviour
{
    //Here we have some private fields where we store object's Linear Velocity (vector and absolute value), Rigidbody and Speed Multiplier 
    private float LinearVelocityMagnitude;
    private Vector3 LinearVelocity;
    private Rigidbody objectsRb;
    private float speedMulti;

    //Here we have a function for initializing appropriately object's Linear Velocity (vector and absolute value)
    void Start()
    {
        LinearVelocityMagnitude = objectsRb.velocity.magnitude;
        LinearVelocity = objectsRb.velocity;
    }

    //Here we have a function for initializing appropriately object's Rigidbody
    private void Awake()
    {
        objectsRb = GetComponent<Rigidbody>();
    }

    //Here we have a function for taking the Linear Velocity (vector) before the collision with another object 
    private void OnCollisionEnter(Collision collision)
    {
        if (speedMulti > 0){LinearVelocity = objectsRb.velocity;}
    }

    //Here we have a function for taking the Linear Velocity (vector) after the collision with another object 
    private void OnCollisionExit(Collision collision)
    {
        if (speedMulti > 0){LinearVelocity = objectsRb.velocity;}
    }



    //Here we have a function Update which is called once per frame
    void Update()
    {
        
        //Here we take the speedMultiplier field from object SpeedMultiplier and we multiply it with 0.1 
        speedMulti = (float)((GameObject.FindGameObjectWithTag("SpeedChanger").GetComponent<SpeedMultiplier>().getSpeedMultiplier())*0.1);
        
        //Here we check if speedMulti is greater than Zero
        if (speedMulti  > 0)
        {
            //Here we change the Linear Velocity (vector) and take the new vector  
            objectsRb.velocity = speedMulti * LinearVelocityMagnitude * (LinearVelocity.normalized);
            LinearVelocity = objectsRb.velocity;
        }
        else
        {
            //Here we change the Linear Velocity (vector) to zero vector  
            objectsRb.velocity = Vector3.zero;
        }
    }
}
