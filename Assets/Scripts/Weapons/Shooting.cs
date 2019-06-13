using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public float speed;
    // Use this for initialization
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject insBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            Rigidbody insBulletRig = insBullet.GetComponent<Rigidbody>();
            insBulletRig.AddForce(transform.right * speed);
               
        }
    }
}
