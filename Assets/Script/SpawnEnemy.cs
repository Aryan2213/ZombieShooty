using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject container;
    public GameObject enemy;

    public int posX, posZ;
    public int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (enemyCount < 30)
        {
            posX = Random.Range(-100, 200);
            posZ = Random.Range(-100, 140);
            Vector3 enemyPoint = new Vector3(posX, -52, posZ);
            GameObject clone = Instantiate(enemy, enemyPoint, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            enemyCount += 1;
            if(enemy.name == "Enemy")
            {
                clone.transform.SetParent(container.transform);
            }
        }
    }
}
