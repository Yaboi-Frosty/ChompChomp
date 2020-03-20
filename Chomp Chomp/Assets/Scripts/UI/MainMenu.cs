using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
//put on main menu canvas. makes buttons interactive.
{

    public Text playerdisplay;

    public void GotoRegistration()
    {
        SceneManager.LoadScene(1);
    }
    public void GotoLogin()
    {
        SceneManager.LoadScene(2);
    }
    public void GotoPlay()
    {
        SceneManager.LoadScene(3);
    }
}