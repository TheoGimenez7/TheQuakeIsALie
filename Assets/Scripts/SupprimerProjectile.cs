using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupprimerProjectile : MonoBehaviour
{

    // Use this for initialization
    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        Destroy(gameObject);
    }

}
