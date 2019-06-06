using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SupprimerProjectile : MonoBehaviour
{

    //[SerializeField]
    //private AudioClip[] impactSound;
    //private AudioSource audioSource;

    [SerializeField]
    public Player joueur;

    public void Start()
    {
        //audioSource = GetComponent<AudioSource>();
        Destroy(gameObject, 2);
    }


   private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

            foreach (GameObject player in players)
            {
                Debug.Log(transform.name);
                if (player.GetComponent<Player>().username == transform.name)
                { 
                    player.GetComponent<Player>().Kills += 1 -1;
                    Debug.Log(player.GetComponent<Player>().Kills);
                    Destroy(gameObject);
                }
            }
            
        }
        else
        {
            Destroy(gameObject);
        }
            

        //Destroy(gameObject);
        //Debug.Log("Touché");
    }
}
