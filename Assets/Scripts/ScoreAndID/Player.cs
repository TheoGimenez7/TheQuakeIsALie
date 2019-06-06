using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private int kills;

    public int Kills
    {
        get { return kills; }
        set { kills = value; }
    }

    private int death;

    public int Deaths
    {
        get { return death; }
        set { death = value; }
    }

    public string username;
}
