using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
[RequireComponent(typeof(AudioSource))]
public class ShotEject : NetworkBehaviour
{

    public Rigidbody bulletcasing;
    private Rigidbody bullet;

    public int ejectSpeed = 10;
    public float fireRate = 0.5f;
    private float nextFire = 0.5f;
    private bool fullAuto = false;

   
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

            bullet = Instantiate(bulletcasing, transform.position, transform.rotation);
            bullet.velocity = transform.TransformDirection(Vector3.back * ejectSpeed);

            audioSource.PlayOneShot(shootSound[Random.Range(0, shootSound.Length)]);
        }
        if (Input.GetKeyDown("v") && Input.GetKeyDown("b")) { fullAuto = !fullAuto; }
        if (fullAuto == true) { fireRate = 0.10f; } else { fireRate = 0.5f; }
    }
}