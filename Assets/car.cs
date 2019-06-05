using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class car : MonoBehaviour {

    public GameObject display_time;
    public float time;
    public float minutes;
    public float secondes;
    public int timer;

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

        if (timer < 0)
        {
            //Do something useful or Load a new game scene depending on your use-case
        }
    }
}
