using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class deminuteur : MonoBehaviour {

    public GameObject display_time;
    public float time;
    public float minutes;
    public float secondes;
    public int timer;

    private bool decompte = true;

    public GameObject[] players;

    // Use this for initialization
    void Start () {

        timer = Mathf.RoundToInt(time);

        minutes = timer / 60;
        secondes = timer % 60;

        display_time.GetComponent<Text>().text = minutes + " : " + secondes;
    }
	
	// Update is called once per frame
	void Update () {

        string sMinutes;
        string sSecondes;

        if (decompte)
        {

            time -= Time.deltaTime;
            timer = Mathf.RoundToInt(time);

            minutes = timer / 60;
            secondes = timer % 60;

            if (minutes < 10)
                sMinutes = "0" + minutes.ToString();
            else
                sMinutes = minutes.ToString();

            if (secondes < 10)
                sSecondes = "0" + secondes.ToString();
            else
                sSecondes = secondes.ToString();

            display_time.GetComponent<Text>().text = sMinutes + " : " + sSecondes;

        }

        if (timer <= 0)
        {
            decompte = false;
            display_time.GetComponent<Text>().text = "Fin de la partie";
            players = GameObject.FindGameObjectsWithTag("Player");

            foreach (GameObject player in players)
            {
                player.GetComponent<FirstPersonController>().m_WalkSpeed = 0;
                player.GetComponent<FirstPersonController>().m_RunSpeed = 0;
                player.GetComponent<ShotEject>().enabled = false;
            }
        }
    }
}
