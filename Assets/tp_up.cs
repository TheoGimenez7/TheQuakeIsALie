using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Networking;

public class tp_up : MonoBehaviour
{
    [SerializeField] public GameObject text;
    [SerializeField] public GameObject playerATP;
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

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "player")
        {
            text.SetActive(false);
        }
    }
}
