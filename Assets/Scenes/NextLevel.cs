using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D col)
    {

        // Every time the player goes to the exit load back the menu 
        if (col.name == "Player")
        {
            SceneManager.LoadScene("Menu");
        }
    }

}
