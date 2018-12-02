using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogIn : MonoBehaviour {

    public InputField namefield;
    public InputField pass;

    public Button submit;

    public void callLogin()
    {
        //Debug.Log(namefield.text + " " + pass.text);
        StartCoroutine(Login());
    }

    IEnumerator Login()
    {

        WWWForm form = new WWWForm();
        Debug.Log(namefield.text + " " + pass.text);
        form.AddField("name", namefield.text);
        form.AddField("pass", pass.text);

        WWW www = new WWW("http://starling5718.getlark.hosting/Login.php", form);
        
        yield return www;

        string[] ms = www.text.Split(' ');
        string result = string.Join(".", ms);
        Debug.Log(result);
        Debug.Log(www.text[0]);




        if (www.text[0] == '0')
        {
            DBManager.userName = namefield.text;
            DBManager.score = int.Parse(www.text.Split('\t')[1]);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
        }
        else
        {
            Debug.Log("User login failed " + www.text);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
        }

    }

    

}
