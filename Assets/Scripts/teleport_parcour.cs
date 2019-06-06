using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Networking;

public class teleport_parcour : MonoBehaviour
{
    [SerializeField] public GameObject text;
    [SerializeField] public GameObject playerATP;
    [SerializeField] public Transform Destination;
    // Use this for initialization
    void Start()
    {
        text.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "player")
        {
            text.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "player")
        {
            if (Input.GetButton("Interact"))
            {
                playerATP.transform.position = Destination.transform.position;
                
                Debug.Log("PERSO  :"+playerATP.transform.position.ToString());
                Debug.Log("BUTTON :"+transform.position.ToString());
            }
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "player")
        {
            text.SetActive(false);
        }
    }
}
