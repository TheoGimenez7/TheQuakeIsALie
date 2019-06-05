using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonEvent : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
      /*  GameObject text_event = new GameObject();
        text_event = GameObject.FindGameObjectWithTag("button_event_test");
        text_event.SetActive(false);*/
    }

    // Update is called once per frame
    void Update()
    {

    }
    /*
    private void TriggerEnter(Collider collision)
    {
        Debug.Log("TRIGGER ENTER");
        if (collision.gameObject.tag == "button_test")
        {
            GameObject text_event = new GameObject();
            Debug.Log("CUBE");
            text_event = GameObject.FindGameObjectWithTag("button_event_test");
            text_event.SetActive(true);
        }
    }

    private void TriggerLeft(Collider collision)
    {
        if (collision.gameObject.tag == "button_test")
        {
            GameObject text_event = new GameObject();
            text_event = GameObject.FindGameObjectWithTag("button_event_test");
            text_event.SetActive(false);
        }
    }*/
}
