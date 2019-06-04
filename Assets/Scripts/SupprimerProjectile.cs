using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupprimerProjectile : MonoBehaviour
{

    // Use this for initialization
    private void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
        Debug.Log(col);

    }

}
