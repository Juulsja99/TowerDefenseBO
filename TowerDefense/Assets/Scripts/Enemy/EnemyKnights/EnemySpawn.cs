using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Spawnpoint;
    public GameObject Enemyprefab;


    private void Update()
    {
        SpawnNewEnemy();
    }

    void SpawnNewEnemy()
    {
        int randomNumber = Mathf.RoundToInt(Random.Range(5f, Spawnpoint.layer - 1));
        Instantiate(Enemyprefab, Spawnpoint.transform.position, Quaternion.identity);
        
    }
}
