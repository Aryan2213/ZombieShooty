using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChasing : MonoBehaviour
{
    public float moveSpeed = 4;
    private Transform player;
    public float distance = 10;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, distance);
    }

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 7;
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        transform.position += transform.forward * moveSpeed * Time.deltaTime;

        if (Vector3.Distance(transform.position, player.position) < distance)
        {
            StartCoroutine(stopAttack());
        }

    }


    IEnumerator stopAttack()
    {
        moveSpeed = 0;
        yield return new WaitForSeconds(4);
        moveSpeed = 7;
    }
}
