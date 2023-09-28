using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public PlayerDoDamage damage;

    private void Update()
    {
        if(health <= 2)
        {
            Destroy(gameObject);
        }

        Debug.Log(health);
    }

    public void TakeDamage(int damage)
    {
        health-=(int)damage;
        Debug.Log("Test");
    }
}
