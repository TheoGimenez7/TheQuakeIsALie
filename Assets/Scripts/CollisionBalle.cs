using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(AudioSource))]
public class CollisionBalle : NetworkBehaviour
{


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


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Debug.Log("Touché sans audio");
            audioSource.PlayOneShot(deathSound[Random.Range(0, deathSound.Length)]);
            Debug.Log("Touché avec audio");
            CmdRespawn();
        }
    }

      //[Command]
    private void CmdRespawn()
    {
        Debug.Log("Coulé");
        /*GameObject[] spawnPoints1 = GameObject.FindGameObjectsWithTag("PointSpawn");
        int tirageSpawn = Random.Range(0, spawnPoints1.Length);*/
        Transform _spawnPoint = NetworkManager.singleton.GetStartPosition();
        transform.position = _spawnPoint.position;
        transform.rotation = _spawnPoint.rotation;
    }
}
