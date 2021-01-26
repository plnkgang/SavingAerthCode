using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        LevelLoader.instance.LoadNextLevel("1stLevel");
    }

    public void PlayGameFromDeathScreen()
    {
        LevelLoader.instance.LoadNextLevel("1stLevel");
    }

    public void GoToMainMenu()
    {
        LevelLoader.instance.LoadNextLevel("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
