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
            audioSource.PlayOneShot(deathSound[Random.Range(0, deathSound.Length)]);
            StartCoroutine(Respawn());
        }
    }

    private IEnumerator Respawn()
    {
        /*GameObject[] spawnPoints1 = GameObject.FindGameObjectsWithTag("PointSpawn");
        int tirageSpawn = Random.Range(0, spawnPoints1.Length);*/
        yield return new WaitForSeconds(0f);
        Transform _spawnPoint = NetworkManager.singleton.GetStartPosition();
        transform.position = _spawnPoint.position;
        transform.rotation = _spawnPoint.rotation;
    }
}
