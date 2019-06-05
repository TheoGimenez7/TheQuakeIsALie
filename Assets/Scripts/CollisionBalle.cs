using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CollisionBalle : MonoBehaviour {


    [SerializeField]
    private AudioClip[] deathSound;
    private AudioSource audioSource;

    [SerializeField]
    private Behaviour[] disableOnDeath;
    private bool[] wasEnabled;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

  
    private void OnCollisionEnter(Collision collision, string _playerID)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            audioSource.PlayOneShot(deathSound[Random.Range(0, deathSound.Length)]);
            Player _player = GameManager.GetPlayer(_playerID);
            Respawn();
        }
    }

    private void Respawn()
    {
        GameObject[] spawnPoints1 = GetComponents(Spawnpoint);
    }
}
