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
        public bool isDead = false;

        public int scoreValue;

        // ------------------------------------------------- //


        // ------------------------------------------------- //
       

        

        public void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "Bullet")
            {
                TakeDamage();
                
            }
        }

        public void DestroyCol()

        {
            enemy.enabled = false;
        }
        void TakeDamage()
        {
            health -= damage;
            if (health <= 0)
            {
                anim.SetBool("Death", true);
                
                if(health == 0)
                {
                    ScoreManager.value += scoreValue;
                }
            }
           

        }
        void Death()
        {
            
            Destroy(this.gameObject);
            
        }

    }
}