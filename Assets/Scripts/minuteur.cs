using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class minuteur : MonoBehaviour
{

    [SerializeField] public GameObject display_time;
    [SerializeField] public GameObject display_pannel;
    [SerializeField] public Transform Destination;

    [SerializeField] public GameObject display_text_final;
    [SerializeField] public GameObject display_time_final;
    [SerializeField] public GameObject display_pannel_final;

    [SerializeField] public GameObject player;

    private float time;
    private float minutes = 0;
    private int timer;
    private string sMinutes = "";
    private string sSecondes = "";
    [SerializeField] public GameObject parcour_respawn;
    [SerializeField] public GameObject parcour_quit;

    // Use this for initialization
    void Start()
    {
        display_time.GetComponent<Text>().text = "00 : 00";
        display_text_final.SetActive(false);
        display_time_final.SetActive(false);
        display_pannel_final.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timer = Mathf.RoundToInt(time);

        if (timer < 60)
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

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "final_plat")
        {
            display_time.SetActive(false);
            display_pannel.SetActive(false);

            display_time_final.GetComponent<Text>().text = sMinutes + "minutes " + sSecondes + "secondes";
            display_text_final.SetActive(true);
            display_time_final.SetActive(true);
            display_pannel_final.SetActive(true);

            parcour_respawn.SetActive(true);
            parcour_quit.SetActive(true);

            GameObject.FindGameObjectWithTag("player").GetComponent<FirstPersonController>().m_WalkSpeed = 0;
            GameObject.FindGameObjectWithTag("player").GetComponent<FirstPersonController>().m_RunSpeed = 0;
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "final_plat")
        {            
            if(Input.GetButton("Cancel"))
            {
                SceneManager.LoadScene("MenuV3");
            }
            else if (Input.GetButton("parcour_respawn"))
            {
                GameObject.FindGameObjectWithTag("player").GetComponent<FirstPersonController>().m_WalkSpeed = 20;
                GameObject.FindGameObjectWithTag("player").GetComponent<FirstPersonController>().m_RunSpeed = 20;

                display_text_final.SetActive(false);
                display_time_final.SetActive(false);
                display_pannel_final.SetActive(false);

                parcour_respawn.SetActive(false);
                parcour_quit.SetActive(false);

                time = 0;
                timer = 0;
                sMinutes = "";
                sSecondes = "";

                display_time.SetActive(true);
                display_pannel.SetActive(true);

                transform.position = Destination.transform.position;
            }
        }
    }
}
