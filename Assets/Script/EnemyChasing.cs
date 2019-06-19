using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChasing : MonoBehaviour
{
    private float moveSpeed = 4;
    public float speed;
    private Transform player;
    public float distance = 1;
    public float stopTime;
    public Animator anim;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, distance);
    }

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = speed;
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

   
        transform.LookAt(player);
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
        

        if (Vector3.Distance(transform.position, player.position) < distance)
        {
            anim.SetTrigger("Attack");
            StartCoroutine(stopAttack());
        }
        

    }


    IEnumerator stopAttack()
    {
        moveSpeed = 0;
      
        yield return new WaitForSeconds(stopTime);
        moveSpeed = speed;
    }
}
