using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    #region Varibles
    public float maxHealth = 250;
    public float playerHealth;
    public float takeDamage = 15;

    public float lerpSpeed = 10;
    public float damageTimeout = 2f;
    private bool canTakeDamage = true;

    public Slider playerHealthBar;
    public GameObject hurt;
    public GameObject dieScreen;
    #endregion

    // Use this for initialization
    void Start()
    {
        // Set players health to starting health value
        playerHealth = maxHealth;
        playerHealthBar.value = playerHealth / maxHealth;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (canTakeDamage && collision.gameObject.tag == "Enemy")
        {

            PlayerTakeDamage();
            Debug.Log("Help");

            StartCoroutine(damageTimer());
        }
    }

    public void PlayerTakeDamage()
    {
        // Player takes damage
        playerHealth -= takeDamage;
        // Set health bar to lower




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
    void Update()
    {
        if(playerHealthBar.value != playerHealth)
        {
            playerHealthBar.value = Mathf.Lerp(playerHealthBar.value, playerHealth/maxHealth, Time.deltaTime * lerpSpeed);
        }
        //playerHealthBar.value = playerHealth / maxHealth;
    }
    private IEnumerator damageTimer()
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(damageTimeout);
        canTakeDamage = true;
    }
}
