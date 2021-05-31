using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Sphere : MonoBehaviour
{
    //Here we store a bool for enabling or disabling the texture, texture Material, color Material, Sphere speed and the Path of texture image in ApplicationBuild folder 
	bool texture = false;
    public Material t_Material;
    public Material c_Material;
	float sphereSpeed = 0.09f;
	string filePath;

	//Here we have a function for getting the Path of texture image at the beggining of our Application 
	void Start(){
		
		//Here we get the Path
		filePath = System.IO.Directory.GetCurrentDirectory() + "\\texture-sphere.jpg";
		
		//Here we make a texture 2D object
		Texture2D texture = null;
		
		//Here we make an Array for storing our texture image data 
		byte[] fileData;

		if (File.Exists(filePath))
		{
			//Here we read the bytes from our texture image and we initialize appropriately our texture 2d object 
			fileData = File.ReadAllBytes(filePath);
			texture = new Texture2D(2, 2);
			texture.LoadImage(fileData);
		}

		//Here we assign the texture object in the texture Material
		t_Material.SetTexture("_MainTex", texture);

	}

	//Here we have a function for implementing the Movement of Sphere (SPH)
	void sphereMovement()
	{
		//Here we take Sphere's initial position
		Vector3 spherePosition = transform.position;


		if (Input.GetKey(KeyCode.UpArrow) && (spherePosition.z + sphereSpeed < 85))
		{
			//Here we move Sphere in positive part of z axis
			spherePosition.z += sphereSpeed;
		}
		if (Input.GetKey(KeyCode.DownArrow) && (spherePosition.z - sphereSpeed > 15))
		{
			//Here we move Sphere in negative part of z axis
			spherePosition.z -= sphereSpeed;
		}
		if (Input.GetKey(KeyCode.LeftArrow) && (spherePosition.x - sphereSpeed > 15))
		{
			//Here we move Sphere in negative part of x axis
			spherePosition.x -= sphereSpeed;
		}
		if (Input.GetKey(KeyCode.RightArrow) && (spherePosition.x + sphereSpeed < 85))
		{
			//Here we move Sphere in positive part of x axis
			spherePosition.x += sphereSpeed;
		}
		if (Input.GetKey(KeyCode.Minus) && (spherePosition.y - sphereSpeed > 15))
		{
			//Here we move Sphere in negative part of y axis
			spherePosition.y -= sphereSpeed;
		}
		if (Input.GetKey(KeyCode.Equals) && Input.GetKey(KeyCode.LeftShift) && (spherePosition.y + sphereSpeed < 85))
		{
			//Here we move Sphere in positive part of y axis
			spherePosition.y += sphereSpeed;
		}

		//Here we give in Sphere (SPH) the new position
		transform.position = spherePosition;
	}

	//Here we have a function textureHandle which checks if user pressed T and if it is true, it changes appropriately the Sphere Material and bool texture 
	void textureHandle()
    {
		if (Input.GetKeyDown(KeyCode.T))
		{
			texture = !texture;
			if (texture) { GetComponent<Renderer>().material = t_Material; }
			else { GetComponent<Renderer>().material = c_Material; }
		}
	}

	//Here we have a function Update which is called once per frame and calls textureHandle() and sphereMovement()
	void Update()
    {
		textureHandle();
		sphereMovement();
	}
}
