using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GainGold : MonoBehaviour
{
    public int gold = 0;
    public EnemyHealth enemyhealth;


    private void Update()
    {
        Debug.Log(gold);

        if (enemyhealth.currentHealth <= 1) 
        {
            gold += 2;
            Debug.Log("GOLD");
            
            
        }
    }
}
