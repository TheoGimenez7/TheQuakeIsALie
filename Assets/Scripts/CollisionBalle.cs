using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBalle : MonoBehaviour {

    // Use this for initialization
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Debug.Log("PTDR ! T MOR :')))))) ");
        }
    }
}
