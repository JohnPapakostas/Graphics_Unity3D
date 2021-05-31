using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneLoad : MonoBehaviour
{
    //Here we have a function for going from Start Scene (Main Menu) to Central Scene (Game Scene)
    public void LoadGameScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    //Here we have a function for exiting from our Application
    public void QuitGameScene()
    {
        Application.Quit();
    }

}
