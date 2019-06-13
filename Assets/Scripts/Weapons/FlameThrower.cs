using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : MonoBehaviour
{
    public GameObject fireBullet;
    public float fireSpeed;   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject insBullet = Instantiate(fireBullet, transform.position, Quaternion.identity) as GameObject;
            Rigidbody insBulletRig = insBullet.GetComponent<Rigidbody>();
            insBulletRig.AddForce(transform.right * fireSpeed);

        }
    }
}
