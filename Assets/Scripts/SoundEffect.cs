using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    //Here we have a private field for storing our Audio Source
    AudioSource sphereSound;

    //Here we have a function for initializing our Audio Source in the beggining of our Application 
    void Start()
    {
        sphereSound = GetComponent<AudioSource>();    
    }

    //Here we have a function for playing our Audio Source when Central Sphere (SPH) collides with Random Created Objects or Player (which is represented as a Capsule)
    void OnCollisionEnter(Collision collision)
    {
        sphereSound.Play();
    }
}
