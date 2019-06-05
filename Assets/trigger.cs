using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trigger : MonoBehaviour
{
    public GameObject text;    
    public GameObject porte;
    [SerializeField] int vitesse;
    // Use this for initialization
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

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
        if(collision.gameObject.tag == "player")
        {
            if(Input.GetButton("Interact"))
            {
                porte.transform.Translate(Vector3.up * Time.deltaTime * vitesse);
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
