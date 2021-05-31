using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedMultiplier : MonoBehaviour
{
    //Here we have a private field for storing speedMultiplier
    private int speedMultiplier;

    //Here is a function for initializing the speedMultiplier at the beggining of our Application
    void Start()
    {
        speedMultiplier = 10;
    }

    //Here is a function for getting the field speedMultiplier
    public int getSpeedMultiplier()
    {
        return speedMultiplier;
    }

    //Here is a function Update which is called once per frame
    void Update()
    {
        //Here we check if user pressed Shift and Period (>) (Period button works digitally)
        if ((Input.GetKey(KeyCode.LeftShift)) && (Input.GetKeyDown(KeyCode.Period)))
        {
            //Here we check if speedMultiplier has reached a maximum value 
            if (speedMultiplier < 100)
            {
                //Here we increase speedMultiplier by one
                speedMultiplier++;
            }
           
        }

        //Here we check if user pressed Shift and Comma (<) (Comma button works digitally)
        if ((Input.GetKey(KeyCode.LeftShift)) && (Input.GetKeyDown(KeyCode.Comma)))
        {
            //Here we check if speedMultiplier has reached a minimum value 
            if (speedMultiplier - 1 >= 0)
            {
                //Here we decrease speedMultiplier by one
                speedMultiplier--;
            }
            else
            {
                //Here we make speedMultiplier equal to zero
                speedMultiplier = 0;
            }
        }
    }
}
