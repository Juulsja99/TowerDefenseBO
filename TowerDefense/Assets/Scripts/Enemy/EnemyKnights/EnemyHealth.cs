using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public AudioClip ouch;
    public GameObject blood;
    public PlayerDoDamage damage;
    [SerializeField] private GainGold gainGold;
    [SerializeField] private int killWorth = 2;
  

    private void Start()
    {
        currentHealth = maxHealth;
        Debug.Log(currentHealth);
        gainGold=FindAnyObjectByType<GainGold>();
    }

    void Update()
    {
        if(currentHealth <= 0)
        {
           
            Die();
            
           
        }
    }

    private void Die()
    {
        gainGold.GoldGained(killWorth);
        AudioSource.PlayClipAtPoint(ouch, transform.position);
        Instantiate(blood, transform.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -=damage;
       
    }
}
