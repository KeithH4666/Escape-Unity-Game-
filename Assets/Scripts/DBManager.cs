using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DBManager {

    public static string userName;
    public static int score;

    public static bool loggedIn { get { return userName != null; } }

    public static void logOut()
    {
        userName = null;
    }
	
}
