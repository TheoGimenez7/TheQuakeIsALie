using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(AudioSource))]
public class SupprimerProjectile : MonoBehaviour
{
    /*
    [SerializeField]
    private AudioClip[] impactSound;
    private AudioSource audioSource;*/

    private bool boul = true ;

    [SerializeField]
    public Player joueur;

    public void Start()
    {
        //audioSource = GetComponent<AudioSource>();
        Destroy(gameObject, 2);
    }


   private void OnCollisionEnter(Collision collision)
    {

        //if (transform != null) audioSource.PlayOneShot(impactSound[Random.Range(0, impactSound.Length)]);

        if (collision.gameObject.tag == "Player" && boul == true)
        {
            GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
            foreach (GameObject player in players)
            {
                if (player.GetComponent<Player>().username == transform.name)
                { 
                    player.GetComponent<Player>().Kills += 1;
                    Destroy(gameObject);
                    boul = false;
                }
                else
                {
                    boul = true;
                }
            }
            
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
