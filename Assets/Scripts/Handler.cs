using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Handler : MonoBehaviour {

	public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
        PauseMenu.gamePaused = false;
    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    public void Register()
    {
        SceneManager.LoadScene("Register");
    }

    public void LogIn()
    {
        SceneManager.LoadScene("LogIn");
    }
}
