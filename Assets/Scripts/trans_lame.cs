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
            if (this.transform.position.x <= -19)
                transform.Translate(Vector3.left * Time.deltaTime * vitesse);
            else
                avance = false;
        }

        if (!avance)
        {
            if (this.transform.position.x >= -42)
                transform.Translate(Vector3.right * Time.deltaTime * vitesse);
            else
                avance = true;
        }
    }
}
