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

        //Quand on appui sur "Z" l'animation de course se declenche
        if (Input.GetKey(KeyCode.Z))
        {
            Anim.SetBool("run", true);
        }

        //Quand on appui sur "Z" l'animation de course s'arrête
        if (Input.GetKeyUp(KeyCode.Z))
        {
            Anim.SetBool("run", false);
        }
	}
}
