using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthbar : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public EnemyDoDamage damage;
    public AudioClip death;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (currentHealth <= 0)
        {

            Die();


        }
    }

    void Die()
    {
        AudioSource.PlayClipAtPoint(death, transform.position);
        Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

    }
}
