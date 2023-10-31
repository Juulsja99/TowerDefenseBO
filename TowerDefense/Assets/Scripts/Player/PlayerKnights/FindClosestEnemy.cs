using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindClosestEnemy : MonoBehaviour
{
    public GameObject[] AllEnemy;
    public GameObject NearestEnemy;
    float Distance;
    float NearestDistance = 10000;

    private void Update()
    {
        AllEnemy = GameObject.FindGameObjectsWithTag("Enemy");

        for ( int i = 0; i < AllEnemy.Length; i++)
        {
            Distance = Vector3.Distance(this.transform.position , AllEnemy[i].transform.position);

            if ( Distance < NearestDistance ) 
            {
                NearestEnemy= AllEnemy[i];
                NearestDistance = Distance;
            }
        }
    }
}
