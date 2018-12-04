using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {

    public Text highScore;

	// Use this for initialization
	void Start () {

        StartCoroutine(getHighscores());
		
	}

    IEnumerator getHighscores()
    {
        Debug.Log("In  function");
        


        WWW www = new WWW("http://starling5718.getlark.hosting/getHighscore.php");
        yield return www;

        Debug.Log(www.text);

        highScore.text = www.text;

    }

    public void mainmenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
