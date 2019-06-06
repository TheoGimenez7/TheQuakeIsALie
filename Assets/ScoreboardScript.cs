using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreboardScript : MonoBehaviour {

    [SerializeField]
    public GameObject playerScoreboardItem;

    [SerializeField]
    private Transform playerScoreboardList;

    // Use this for initialization
    
    void OnEnable()
    {
        Debug.Log("4");
        //Player[] players = GameManager.GetAllPlayers();
        GameObject[] players =GameObject.FindGameObjectsWithTag("Player");
        Debug.Log(players);
        foreach (GameObject player in players)
        {
            
            Debug.Log(player.name);
            GameObject ItemPlayersScore =(GameObject) Instantiate(playerScoreboardItem, playerScoreboardList);
            JoueurScoreBoardObjetScript item = ItemPlayersScore.GetComponent <JoueurScoreBoardObjetScript>();
            if (item !=null)
            {
                Debug.Log("6");
                item.Setup(player.name , 6 , 9);
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

}
