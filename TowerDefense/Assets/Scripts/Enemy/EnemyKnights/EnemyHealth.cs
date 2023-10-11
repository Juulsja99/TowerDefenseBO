using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public PlayerDoDamage damage;
  

    private void Start()
    {
        currentHealth = maxHealth;
        Debug.Log(currentHealth);
    }

    void Update()
    {
        if(currentHealth <= 0)
        {
          
            Destroy(gameObject);
           
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -=damage;
       
    }
}
