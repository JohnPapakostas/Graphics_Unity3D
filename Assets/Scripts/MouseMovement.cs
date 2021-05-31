using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseMovement : MonoBehaviour
{
    //Here we have some private fields where we store Mouse Sensitivity, the Transform of Player Character and Rottation in X axis
    public float mouseSensitivity = 25f;
    public Transform PlayerCharacter;
    float RotationX = 0.0f;

    //Here we have a function for locking Mouse Cursor and make it invisible at the beggining of our Application 
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    //Here we have a function Update which is called once per frame
    void Update()
    {

        //Here we get Mouse Position in X and Y axis and we multiply it with mouseSensitivity and deltaTime 
        float mousePositionX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mousePositionY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //Here we calculate RotationX , we call Clamp function to limit the rotation and we finally rotate our object (PlayerCharacter)
        RotationX -= mousePositionY;
        RotationX = Mathf.Clamp(RotationX, -180.0f, 180.0f); //(360 degrees rotation )
        transform.localRotation = Quaternion.Euler(RotationX, 0f, 0f);
        PlayerCharacter.Rotate(Vector3.up * mousePositionX);

        //Here we check if user pressed ESC button in keyboard 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Here we unlock Mouse Cursor, make it visible and return from Central Scene (Game Scene) to Start Scene (Main Menu) 
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
        }
    }
}
