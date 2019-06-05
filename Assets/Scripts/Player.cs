using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Health = 30;
    public float curHealth;

    public float hurt = 5;
    public float range = 2f;

    public float speed = 5;
    public float jumpHeight = 10f;

    public GameObject weaponArea;
    
    // Start is called before the first frame update
    void Start()
    {
        curHealth = Health;      
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            weaponArea.SetActive(true);
            Debug.Log("Attack");
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            weaponArea.SetActive(false);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            JonnyCash();
            Debug.Log("Aaaahhhhhhh");
        }
    }

    public void Attack()
    {
       
    }

    public void JonnyCash()
    {
        curHealth -= hurt;
        if(curHealth < 0)
        {
            Destroy(gameObject);
        }
    }
}
