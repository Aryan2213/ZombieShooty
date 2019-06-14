using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

namespace ZombieShooty
{    
    public class Enemy : MonoBehaviour
    {
        public Collider enemy;
        public int health = 100;
        public int damage = 24;
        public Animator anim;

        

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

        public void TakeDamage()
        {
            health -= damage;
            if (health <= 0)
            {
<<<<<<< HEAD
                Destroy(this.gameObject);  
=======
                anim.SetBool("Death", true);
>>>>>>> 6a1bec91ca0fca8e2e4d2497efa9c502f594d979
            }

        }
        void Death()
        {
           
                Destroy(this.gameObject);
           
        }
        void ColiderDisable()
        {
            enemy.enabled = false;
        }

        

    }
}