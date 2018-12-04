using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Handler : MonoBehaviour {

    public Text playerDisplay;
    public Text score;
    public int scoreDB;

    public void Update()
    {
        
        score.text = "Players current score = " + DBManager.score;
    }

    private void Start()
    {
        if (DBManager.loggedIn)
        {
            playerDisplay.text = "Player: " + DBManager.userName;
        }

        ScoreUpdate.scoreValue = 0;
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

    public void Highscores() {
        SceneManager.LoadScene("Highscore");
    }

    public void LogIn()
    {
        SceneManager.LoadScene("LogIn");
    }

    IEnumerator getScore()
    {

        WWWForm form = new WWWForm();
        
        form.AddField("name", DBManager.userName);
        

        WWW www = new WWW("http://starling5718.getlark.hosting/getScore.php", form);

        yield return www;


    }
}
