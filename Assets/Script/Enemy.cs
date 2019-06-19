using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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

        void TakeDamage()
        {
            health -= damage;
            if (health <= 0)
            {
                anim.SetBool("Death", true);
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