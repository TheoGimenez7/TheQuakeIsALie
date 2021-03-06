﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(AudioSource))]
public class CollisionBalle : NetworkBehaviour
{

    [SerializeField]
    public Player joueur;


    [SerializeField]
    private AudioClip[] deathSound;
    private AudioSource audioSource;

    [SerializeField]
    private Behaviour[] disableOnDeath;
    private bool[] wasEnabled;

    private bool boul = true ;
    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile" || collision.gameObject.tag == "Player")
        {
            
            
            
            StartCoroutine(Respawn());

            if (boul)
            {
                joueur.Deaths += 1;
                boul = false;
            }
            else
                boul = true;
        }
        audioSource.PlayOneShot(deathSound[Random.Range(0, deathSound.Length)]);
    }

    private IEnumerator Respawn()
    {
        yield return new WaitForSeconds(0.001f);
        Transform _spawnPoint = NetworkManager.singleton.GetStartPosition();
        transform.position = _spawnPoint.position;
        transform.rotation = _spawnPoint.rotation;
    }
}
