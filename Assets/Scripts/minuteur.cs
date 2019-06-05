using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minuteur : MonoBehaviour
{

    public GameObject display_time;
    public float time;
    public float minutes = 0;
    public int timer;

    // Use this for initialization
    void Start()
    {
        display_time.GetComponent<Text>().text = "00 : 00";
    }

    // Update is called once per frame
    void Update()
    {

        string sMinutes = "";
        string sSecondes = "";

        time += Time.deltaTime;
        timer = Mathf.RoundToInt(time);

        if(timer < 60)
        {
            if (timer < 10)
                sSecondes = "0" + timer.ToString();
            else
                sSecondes = timer.ToString();
        }
        else
        {
            minutes++;
            time = 0;
            timer = 0;
        }

        if (minutes < 10)
            sMinutes = "0" + minutes.ToString();
        else
            sMinutes = minutes.ToString();

        display_time.GetComponent<Text>().text = sMinutes + " : " + sSecondes;

    }
}
