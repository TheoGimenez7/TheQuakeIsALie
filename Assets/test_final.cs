using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_final : MonoBehaviour {
    public GameObject player;
    public Transform Destination;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="player")
        {
            player.transform.position = Destination.transform.position;
        }
    }
}
