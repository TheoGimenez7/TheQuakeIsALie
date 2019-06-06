using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Player))]
public class JoueurScoreBoardObjetScript : MonoBehaviour {
    [SerializeField]
    Text usernameText;
    [SerializeField]
    Text killstext;
    [SerializeField]
    Text deathsText;

    public void Setup(string username , int kills , int deaths)
    {
        usernameText.text = username;
        killstext.text ="Kills : " + kills;
        deathsText.text = "Deaths : " + deaths;
        Debug.Log("7");

    }
}
