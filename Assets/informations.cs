using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class informations : MonoBehaviour {
    [SerializeField] public GameObject canvas;
	// Use this for initialization
	void Start () {
        canvas.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "info_plat")
        {
            canvas.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "info_plat")
        {
            canvas.SetActive(false);
        }
    }
}
