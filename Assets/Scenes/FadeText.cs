using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FadeText : MonoBehaviour {

    public Text splashText;
    public Text splashText2;
    public string loadLevel;

    IEnumerator Start()
    {
        splashText.canvasRenderer.SetAlpha(0.0f); // sets the transparcy to invisable
        splashText2.canvasRenderer.SetAlpha(0.0f);
        FadeIn();
        yield return new WaitForSeconds(2.5f);
        FadeOut();
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(loadLevel);
    }

    void FadeIn()
    {
        splashText.CrossFadeAlpha(1.0f, 1.5f, false);
        splashText2.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    void FadeOut()
    {
        splashText.CrossFadeAlpha(0.0f, 2.5f, false);
        splashText2.CrossFadeAlpha(0.0f, 2.5f, false);
    }


}
