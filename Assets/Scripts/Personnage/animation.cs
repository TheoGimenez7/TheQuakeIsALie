using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour {

    private Animator Anim;
	// Use this for initialization
	void Start () {
        Anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Z))
        {
            Anim.SetBool("run", true);
        }
	}
}
