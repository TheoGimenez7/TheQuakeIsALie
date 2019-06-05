using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public GameObject txt;
    private int score_player = 0;
    // Use this for initialization
    void Start()
    {
        txt.GetComponent<Text>().text = "Score : 0";
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "plateforme_score")
        {
            score_player++;
            txt.GetComponent<Text>().text = "Score : " + score_player.ToString();
        }
    }
}
