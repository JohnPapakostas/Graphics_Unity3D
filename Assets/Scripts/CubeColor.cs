using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour
{
    //Here we have a function for creating randomly the color of our Central Cube (SC) and making Central Cube transparent at the beginning of our Application  
    void Start()
    {
        GetComponent<Renderer>().material.color = new Color(Random.Range(0.0f,1.0f),Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f),0.3f);
    }

}
