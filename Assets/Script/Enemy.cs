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


        //public GameObject player;
        private Transform target;
        private NavMeshAgent nav;



        // ------------------------------------------------- //


        // ------------------------------------------------- //
        public void Start()
        {
            nav = GetComponent<NavMeshAgent>();
            target = GameObject.FindWithTag("Player").transform;
        }


        void Update()
        {

                nav.SetDestination(target.position);
  
        }

    }
}