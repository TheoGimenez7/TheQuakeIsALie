﻿using System.Collections;
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
        GameObject[] players =GameObject.FindGameObjectsWithTag("Player");
        Debug.Log(players);
        foreach (GameObject player in players)
        {
            

            GameObject ItemPlayersScore =(GameObject) Instantiate(playerScoreboardItem, playerScoreboardList);
            JoueurScoreBoardObjetScript item = ItemPlayersScore.GetComponent <JoueurScoreBoardObjetScript>();
            if (item !=null)
            {
                item.Setup(player.GetComponent<Player>().username, player.GetComponent<Player>().Kills , player.GetComponent<Player>().Deaths);
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