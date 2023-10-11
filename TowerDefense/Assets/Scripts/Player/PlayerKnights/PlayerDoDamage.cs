using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDoDamage : MonoBehaviour
{
    public int damage = 1;
    public EnemyHealth enemyhealth;
    public float attackCooldown;
    float lastAttackTime;


    private void Start()
    {
        //enemyhealth = GameObject.Find("Enemy").GetComponent<EnemyHealth>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
       if(Time.time -lastAttackTime < attackCooldown) 
        {
            return;
        }

        if(collision.gameObject.CompareTag("Enemy"))
        {
            enemyhealth.TakeDamage(damage);
            Debug.Log("damagetaken");
            
            
        }

        lastAttackTime= Time.time;
    }
}
