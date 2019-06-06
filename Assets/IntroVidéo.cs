using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class IntroVidéo : MonoBehaviour {

    public void SkipVideo()
    {
        SceneManager.LoadScene("MenuV3", LoadSceneMode.Single);
    }
}
