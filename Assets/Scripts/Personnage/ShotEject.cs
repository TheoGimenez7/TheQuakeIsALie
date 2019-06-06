using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(AudioSource))]
public class ShotEject : NetworkBehaviour
{
    
    public GameObject bulletcasing;
    private Transform bulletSpawn;

    public int ejectSpeed = 100;
    public float fireRate = 0.5f;
    private float nextFire = 0.5f;
    private bool fullAuto = false;
    public Player joueur;
   
    [SerializeField]
    private AudioClip[] shootSound;
    private AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    public void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            CmdFire();

            audioSource.PlayOneShot(shootSound[Random.Range(0, shootSound.Length)]);
        }
        if (Input.GetKeyDown("v") && Input.GetKeyDown("b")) { fullAuto = !fullAuto; }
        if (fullAuto == true) { fireRate = 0.10f; } else { fireRate = 0.5f; }
    }


    [Command]
    void CmdFire()
    {
        bulletSpawn = transform.Find("FirstPersonCharacter/gun1.2/Eject");
        GameObject bullet =(GameObject) Instantiate(bulletcasing, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward*ejectSpeed;
        
        bullet.transform.name =joueur.username;

        NetworkServer.Spawn(bullet);
    }

}
