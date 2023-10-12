using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> Enemies = new List<GameObject>();
    public float SpawnRate;

    private float x1, y1,x2,y2,x3,y3;
    private Vector3 spawnPos;
    void Start()
    {
        StartCoroutine(SpawnTestEnemy());
    }

    IEnumerator SpawnTestEnemy()
    {
        while (true)
        {
            x1 = Random.Range(-3, 3);
            y1 = Random.Range(-3, 3);
            spawnPos.x += x1;
            spawnPos.y += y1;
            Instantiate(Enemies[0],spawnPos, Quaternion.identity);

            x2 = Random.Range(-2, 1 );
            y2 = Random.Range(-1, 3);
            spawnPos.x += x2;
            spawnPos.y += y2;
            Instantiate(Enemies[1], spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(SpawnRate);

            x3 = Random.Range(-1, 2);
            y3 = Random.Range(-2, 4);
            spawnPos.x += x3;
            spawnPos.y += y3;
            Instantiate(Enemies[2], spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(SpawnRate);
        }
        
    }
}
