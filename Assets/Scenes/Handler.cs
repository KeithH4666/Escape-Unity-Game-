using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Handler : MonoBehaviour {

	public void playGame()
    {
        SceneManager.LoadScene("LevelExample");
    }

    public void quitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
