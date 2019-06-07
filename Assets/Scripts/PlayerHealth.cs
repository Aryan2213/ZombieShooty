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
    public float flashSpeed = 5f;

    private bool canTakeDamage = true;
    private bool damaged = false;
    public Color flashColour = new Color(1f, 0f, 0f, 10f);

    public Slider playerHealthBar, delayHealthBar;
    public Image damageImage;
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
            damaged = true;
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

        if (damaged)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);

        }
        damaged = false;
    }
    private IEnumerator damageTimer()
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(damageTimeout);
        canTakeDamage = true;
    }
   
}
