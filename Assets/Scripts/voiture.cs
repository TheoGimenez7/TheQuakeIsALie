using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voiture : MonoBehaviour {

    private float timer;

    private int dir = 1; // 1 = z up;  2= x right;    3= z down;    4= x left
    [SerializeField] public int vitesse;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        timer = Mathf.RoundToInt(timer);        

        if(transform.position.z > -132 && dir==1)
        {
            transform.Translate(Vector3.left * Time.deltaTime * vitesse);
        }
        else if (transform.position.z <= -132 && dir==1)     
        {
            dir = 2;
            transform.Rotate(0, 90, 0);
        }

        if(transform.position.x > -64 && dir==2)
        {
            transform.Translate(Vector3.left * Time.deltaTime * vitesse);
        }
        else if (transform.position.x <= -64 && dir == 2) 
        {
            dir = 3;
            transform.Rotate(0, 90, 0);
        }
        
        if (transform.position.z < 107 && dir == 3)
        {
            transform.Translate(Vector3.left * Time.deltaTime * vitesse);
        }
        else if (transform.position.z >= 107 && dir==3)
        {
            dir = 4;
            transform.Rotate(0, 90, 0);
        }

        if (transform.position.x < 75 && dir == 4)
        {
            transform.Translate(Vector3.left * Time.deltaTime * vitesse);
        }
        else if (transform.position.x >= 75 && dir==4)
        {
           dir = 1;
            transform.Rotate(0, 90, 0);
        }
    }
}
