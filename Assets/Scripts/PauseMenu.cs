using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    public Button pauseMenu;
    public GameObject pauseMenuUI;

    public static bool gamePaused = false;
    public 

    void Start()
    {
        pauseMenu.onClick.AddListener(TaskOnClick);
        //pauseMenuUI.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (gamePaused)
        {
            pauseMenuUI.SetActive(true);
            Pause();
        }
        else
        {
            pauseMenuUI.SetActive(false);
        }
	}

    void TaskOnClick()
    {
        gamePaused = true;
        
    }

    public void Resume()
    {
        gamePaused = false;
        Time.timeScale = 1f;
    }


    void Pause()
    {
        Time.timeScale = 0f;
    }

}
