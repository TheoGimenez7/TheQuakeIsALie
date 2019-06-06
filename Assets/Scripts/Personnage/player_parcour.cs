using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class player_parcour : MonoBehaviour {

    [SerializeField] public Transform Destination;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.y < -10)
        {
            transform.position = Destination.transform.position;
        }
    }



}
