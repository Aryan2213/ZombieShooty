using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    #region Varibles
    public float maxHealth = 250;
    public float curHealth;
    public float takeDamage = 15;
    [Header("DamageDelay")]
    public float damageTimeout = 2f;
    private bool canTakeDamage = true;
    [Header("healthbar"+"damageBG")]
    public float lerpSpeed = 4f;
    public float flashSpeed = 5f;

    private bool damaged = false;
    public Color flashColour = new Color(1f, 0f, 0f, 10f);

    public Slider playerHealthBar, delayHealthBar;
    public Image damageImage;
    public GameObject hurt;
    public GameObject dieScreen;

    public bool isDead = false;
    [Header("SoundClip")]
    public AudioSource damageSound;
    public AudioSource deadSound;
    #endregion

    // Use this for initialization
    void Start()
    {
        // Set players health to starting health value
        curHealth = maxHealth;
        playerHealthBar.value = curHealth;
        delayHealthBar.value = curHealth;

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
        curHealth -= takeDamage;

        if(curHealth > 0)
        {
            damageSound.Play();
        }
        if (curHealth < 41)
        {
            // Player hurt
            hurt.SetActive(true);
        }

        if (curHealth <= 0)
        {
            
            Death();

        }
    }
    // Update is called once per frame
    void Update()
    {

        if (curHealth != delayHealthBar.value)
        {
            delayHealthBar.value = Mathf.Lerp(delayHealthBar.value, curHealth, Time.deltaTime * lerpSpeed);
        }

        playerHealthBar.value = curHealth;

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
   void Death()
    {
        isDead = true;
        // Would You Kindly Die Sir!
        dieScreen.SetActive(true);
        Time.timeScale = 0;
        delayHealthBar.value = 0;
        playerHealthBar.value = 0;
        deadSound.Play();
    }
}
