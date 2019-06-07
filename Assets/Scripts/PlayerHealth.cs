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

    public float lerpSpeed = 4f;
    public float damageTimeout = 2f;
    private bool canTakeDamage = true;

    public Slider playerHealthBar, delayHealthBar;
    public GameObject hurt;
    public GameObject dieScreen;
    #endregion

    // Use this for initialization
    void Start()
    {
        // Set players health to starting health value
        playerHealth = maxHealth;
        playerHealthBar.value = playerHealth;
        delayHealthBar.value = playerHealth;
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
            delayHealthBar.value = 0;
            playerHealthBar.value = 0;

        }
    }

    // Update is called once per frame
    void Update()
    {

        if (playerHealth != delayHealthBar.value)
        {
            delayHealthBar.value = Mathf.Lerp(delayHealthBar.value, playerHealth, Time.deltaTime * lerpSpeed);
        }

        playerHealthBar.value = playerHealth;
    }
    private IEnumerator damageTimer()
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(damageTimeout);
        canTakeDamage = true;
    }
   
}
