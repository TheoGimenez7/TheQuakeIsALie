using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CollisionBalle : MonoBehaviour {


    [SerializeField]
    private AudioClip[] deathSound;
    private AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Debug.Log("PTDR ! T MOR :')))))) ");
            audioSource.PlayOneShot(deathSound[Random.Range(0, deathSound.Length)]);
        }
    }
}
