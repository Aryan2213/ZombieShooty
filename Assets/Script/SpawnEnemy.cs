using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject container;
    public GameObject enemy,dog;

    public int posX, posZ;
    public int enemyCount, dogCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
        StartCoroutine(SpawnDog());
    }

    IEnumerator Spawn()
    {
        while (enemyCount < 60)
        {
            posX = Random.Range(-100, 200);
            posZ = Random.Range(-100, 140);
            Vector3 enemyPoint = new Vector3(posX, -52, posZ);
            GameObject clone = Instantiate(enemy, enemyPoint, Quaternion.identity);
            yield return new WaitForSeconds(1f);
            enemyCount += 1;
            if(enemy.name == "Enemy")
            {
                clone.transform.SetParent(container.transform);
            }
        }
    }
    IEnumerator SpawnDog()
    {
        while (dogCount < 10)
        {
            posX = Random.Range(-100, 200);
            posZ = Random.Range(-100, 140);
            Vector3 enemyPoint = new Vector3(posX, -52, posZ);
            GameObject clone = Instantiate(dog, enemyPoint, Quaternion.identity);
            yield return new WaitForSeconds(10f);
            dogCount += 1;
            if (dog.name == "Enemy")
            {
                clone.transform.SetParent(container.transform);
            }
        }
    }
}
