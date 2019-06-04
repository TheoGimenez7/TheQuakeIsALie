using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupprimerProjectile : MonoBehaviour
{

    [SerializeField]
    private AudioClip[] impactSound;
    private AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(impactSound[Random.Range(0, impactSound.Length)]);
        Destroy(gameObject);
    }

}
