using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace ZombieShooty
{

    public class Enemy : MonoBehaviour
    {

        public int health = 100;
        public int damage = 24;


       

        // ------------------------------------------------- //


        // ------------------------------------------------- //
       

        

        public void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "Bullet")
            {
                TakeDamage();
                Debug.Log("It Hit");
            }
        }

        void TakeDamage()
        {
            health -= damage;

            if(health <= 0)
            {
                Destroy(this.gameObject);
            }
        }

    }
}