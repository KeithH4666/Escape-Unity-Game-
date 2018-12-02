using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Handler : MonoBehaviour {

    public Text playerDisplay;

    private void Start()
    {
        if (DBManager.loggedIn)
        {
            playerDisplay.text = "Player: " + DBManager.userName;
        }   
    }

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
