using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FPS
{
    public class EnemyHealthBar : MonoBehaviour
    { 
        #region Variables
        public float startHealth = 101; 
        public float health; 
        public int takeDamage = 10;  
         
        public Image healthBar;
        public GameObject hurt;
        #endregion
         
         
        // Use this for initialization 
        void Start() 
        {
            health = startHealth;           
        }
        
        public void TakeDamage()
        {
            health -= takeDamage;
            healthBar.fillAmount = health / startHealth;
            
            if (health < 0)
            {
                // Go Death Go
                hurt.SetActive(true);
            }
        }
        
         // Update is called once per frame
        void Update()
        {
           
                               
        }
    }
}