using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnTime, spawnDelay);
    }

    public void SpawnEnemy()
    {
        for (var i = 0; i < enemyPrefab.Length; i++)
        {

            Instantiate(enemyPrefab[i], transform.position, transform.rotation);
            if (stopSpawning)
            {
                CancelInvoke("SpawnEnemy");
            }
        }

    }
}
