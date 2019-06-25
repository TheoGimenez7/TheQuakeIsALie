using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
[RequireComponent(typeof(Player))]
public class JoueurScoreBoardObjetScript : NetworkBehaviour {
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
        Debug.Log(username);
    }
}
