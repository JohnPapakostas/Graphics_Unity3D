using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorEffects : MonoBehaviour
{
    //Here we have a function for detecting the collision of Random Created Objects with Central Cube Quads (Sides), Central Sphere (SPH) and Player(who is represented as a Capsule) and changing their color
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SC" || collision.gameObject.name == "SPH" || collision.gameObject.name == "PlayerCharacter")
        {
            GetComponent<Renderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f);
        }
       
    }
}
