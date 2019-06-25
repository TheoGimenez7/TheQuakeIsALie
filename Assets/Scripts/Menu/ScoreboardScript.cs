using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ScoreboardScript : NetworkBehaviour {

    [SerializeField]
    public GameObject playerScoreboardItem;

    [SerializeField]
    private Transform playerScoreboardList;

    
    void OnEnable()
    {

        GameObject[] players =GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject player in players)
        {


            GameObject ItemPlayersScore =(GameObject) Instantiate(playerScoreboardItem, playerScoreboardList);
            JoueurScoreBoardObjetScript item = ItemPlayersScore.GetComponent <JoueurScoreBoardObjetScript>();
            if (item !=null)
            {
                Debug.Log(player.GetComponent<Player>().username);
                item.Setup(player.name, player.GetComponent<Player>().Kills , player.GetComponent<Player>().Deaths);
            }
        }
	}

    void OnDisable()
    {
        foreach(Transform child in playerScoreboardList)
        {
            Destroy(child.gameObject);
        }
    }

    private void Reset()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject player in players)
        {


            GameObject ItemPlayersScore = (GameObject)Instantiate(playerScoreboardItem, playerScoreboardList);
            JoueurScoreBoardObjetScript item = ItemPlayersScore.GetComponent<JoueurScoreBoardObjetScript>();
            if (item != null)
            {
                item.Setup(player.GetComponent<Player>().username, player.GetComponent<Player>().Kills, player.GetComponent<Player>().Deaths);
            }
        }
    }

}
