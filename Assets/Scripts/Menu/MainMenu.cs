using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {

    public void PlayGame ()
    {
        SceneManager.LoadScene("multi1", LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PlayParkour()
    {
        SceneManager.LoadScene("MapV1", LoadSceneMode.Single);
    }
}
