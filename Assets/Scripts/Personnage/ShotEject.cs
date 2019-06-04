using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEject : MonoBehaviour
{

    public Rigidbody bulletcasing;
    private Rigidbody bullet;

    public int ejectSpeed = 10;
    public float fireRate = 0.5f;
    private float nextFire = 0.5f;
    private bool fullAuto = false;

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            bullet = Instantiate(bulletcasing, transform.position, transform.rotation);
            bullet.velocity = transform.TransformDirection(Vector3.back * ejectSpeed);
        }
        if (Input.GetKeyDown("v") && Input.GetKeyDown("p")) { fullAuto = !fullAuto; }
        if (fullAuto == true) { fireRate = 0.10f; } else { fireRate = 0.5f; }
    }
}