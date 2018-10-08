using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGameButton : MonoBehaviour {

    public string loadLevel;

    void Start () {

        //Button btn1 = StartGameButton.GetComponent<Button>();
        TaskOnClick();

    }

    void TaskOnClick()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button!");
        SceneManager.LoadScene(loadLevel);
    }

}
