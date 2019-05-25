using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace ZombieShooty
{

    public class Enemy : MonoBehaviour
    {

        public int health = 100;
        public int damage = 25;

        public float attackDelay = 3;
        float lastAttacked = -9999;

        //public GameObject player;
        public Transform target;
        private NavMeshAgent nav;
        float targetDistance;

        // ------------------------------------------------- //


        // ------------------------------------------------- //
        public void Start()
        {
            nav = GetComponent<NavMeshAgent>();
        }


        void Update()
        {
            if (targetDistance < 30f)
            {
                nav.SetDestination(target.position);
            }

            targetDistance = Vector3.Distance(target.position, transform.position);
            if (targetDistance < 1.4f)
            {
                Attack();
            }
        }
        public void Attack()
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                if (hit.collider.gameObject.tag == "Player")
                {

                    if (Time.time > lastAttacked + attackDelay)
                    {

                        print("yes");
                    }
                }
            }




        }
    }
}