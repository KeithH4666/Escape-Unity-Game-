using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour {

    public InputField namefield;
    public InputField pass;

    public Button submit;

    public void callRegister()
    {
        Debug.Log(namefield.text + " " + pass.text);
        StartCoroutine(RegisterUser());
    }

    IEnumerator RegisterUser()
    {
        WWWForm form = new WWWForm();

        form.AddField("name", namefield.text);
        form.AddField("pass", pass.text);

        WWW www = new WWW("http://starling5718.getlark.hosting/sqlconnect.php", form);
        yield return www;
        Debug.Log(www.text);

        if(www.text == "0")
        {
            Debug.Log("user created");
            UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
        }
        else
        {
            Debug.Log("Error " + www.text);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
        }

    }

    public void verifyInputs()
    {
        submit.interactable = (namefield.text.Length > 8 && pass.text.Length > 8);
    }

}
