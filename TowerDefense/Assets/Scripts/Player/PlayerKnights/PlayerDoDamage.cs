using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDoDamage : MonoBehaviour
{
    public int damage = 1;
    public EnemyHealth enemyhealth;
    public TowerHealth towerhealth;
    public float attackCooldown;
    float lastAttackTime;
    public Animator fight;
   

    private void Start()
    {
        enemyhealth= FindAnyObjectByType<EnemyHealth>();
        towerhealth = FindAnyObjectByType<TowerHealth>();
    }

    private void Update()
    {
        enemyhealth = FindAnyObjectByType<EnemyHealth>();
    }



    private void OnCollisionStay2D(Collision2D collision)
    {
       if(Time.time -lastAttackTime < attackCooldown) 
        {
            return;
        }

        if(collision.gameObject.CompareTag("Enemy"))
        {
           
            fight.SetBool("IsAttacking", true);
            enemyhealth.TakeDamage(damage);
            Debug.Log("damagetaken");
            
            
        }

        if (collision.gameObject.CompareTag("Tower2"))
        {
            fight.SetBool("IsAttacking", true);
            towerhealth.TakeDamage(damage);
        }

            lastAttackTime = Time.time;
    }

   
}
