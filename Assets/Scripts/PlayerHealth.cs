using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    #region Varibles
    public float playerStartHealth = 250;
    public float playerHealth;
    public float takeDamage = 15;

    public Image playerHealthBar;
    public GameObject hurt;
    public GameObject dieScreen;
    #endregion

    // Use this for initialization
    void Start ()
    {
        // Set players health to starting health value
        playerHealth = playerStartHealth;
	}

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            PlayerTakeDamage();
            Debug.Log("Help");
        }
    }

    public void PlayerTakeDamage()
    {
        // Player takes damage
        playerHealth -= takeDamage;
        // Set health bar to lower
        playerHealthBar.fillAmount = playerHealth / playerStartHealth;

        if (playerHealth < 41)
        {
            // Player hurt
            hurt.SetActive(true);
        }

        if (playerHealth < 0)
        {
            // Would You Kindly Die Sir!
            dieScreen.SetActive(true);
            Time.timeScale = 0;

        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }
}
