using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trans_lame : MonoBehaviour
{

    [SerializeField] private int vitesse;
    private bool avance = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (avance)
        {
            //if(Vector3.left >= 0)
            transform.Translate(Vector3.left * Time.deltaTime * vitesse);
            Debug.Log(Vector3.left);
            Debug.Log(Vector3.left * Time.deltaTime * vitesse);

        }
    }
}
