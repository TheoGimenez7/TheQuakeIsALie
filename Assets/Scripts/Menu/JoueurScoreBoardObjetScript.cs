using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
[RequireComponent(typeof(Player))]
public class JoueurScoreBoardObjetScript : NetworkBehaviour {
    [SerializeField]
    Text usernameText;
    [SerializeField]
    Text killstext;
    [SerializeField]
    Text deathsText;

    [Command]
    public void Setup(string username , int kills , int deaths)
    {
        usernameText.text = username;
        killstext.text ="Kills : " + kills;
        deathsText.text = "Deaths : " + deaths;

    }
}
