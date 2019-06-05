using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ChacunSonJoueur : NetworkBehaviour {
    
    // Use this for initialization
    // Behaviour c'est la liste des components des objects 
    [SerializeField]
    Behaviour[] specsJoueursADesactiver;
    
    void Start () {
        Debug.Log(specsJoueursADesactiver[0]);
        if (!isLocalPlayer)
        {
            GameObject eject = transform.Find("FirstPersonCharacter/gun1.2/Eject").gameObject;
            GameObject.Find("FirstPersonCharacter/gun1.2").GetComponent<Viser>().enabled = false;
            eject.SetActive(false);

            //Désactive les components des AUTRES Joueurs
            for (int i = 0; i < specsJoueursADesactiver.Length; i++)
            {
                specsJoueursADesactiver[i].enabled = false;
            }


        }
        else
        {
            // On désactive la caméra représentant la map pour avoir QUE celle du joueur
            Camera vueDuSpawn = GameObject.FindWithTag("VueDuDebut").GetComponent<Camera>() as Camera;
            vueDuSpawn.transform.gameObject.SetActive(false);
        }
        

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
