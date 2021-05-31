using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	//Here we have a field for storing the velocity of our Player-Capsule (PlayerCharacter)
	public float speed = 0.9f;


	//Here we have a function Update which is called once per frame and calls playerMovement()
	void Update(){playerMovement();}

	//Here we have a function for implementing the Movement of Player
	private void playerMovement()
	{
		//Here we take Player's initial position
		Vector3 player = transform.position;
		
		if (Input.GetKey(KeyCode.W))
		{
			//Here we move Player in positive part of z axis
			player.z += speed;
		}
		if (Input.GetKey(KeyCode.S))
		{
			//Here we move Player in negative part of z axis
			player.z -= speed;
		}
		if (Input.GetKey(KeyCode.A))
		{
			//Here we move Player in negative part of x axis
			player.x -= speed;
		}
		if (Input.GetKey(KeyCode.D))
		{
			//Here we move Player in positive part of x axis
			player.x += speed;
		}
		if (Input.GetKey(KeyCode.E))
		{
			//Here we move Player in positive part of y axis
			player.y += speed;
		}
		if (Input.GetKey(KeyCode.X))
		{
			//Here we move Player in negative part of y axis
			player.y -= speed;
		}

		//Here we give in our Player the new position
		transform.position = player;
	}
}
