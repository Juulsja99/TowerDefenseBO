using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDoDamage : MonoBehaviour
{
    public int damage = 2;
    public int attackCooldownTime;
    public float lastAttackTime;
    public PlayerHealthbar playerhealth;
    public Tower1Health towerhealth;
    public Animator fight;

    private void Start()
    {
        playerhealth = FindAnyObjectByType<PlayerHealthbar>();
        towerhealth = FindAnyObjectByType<Tower1Health>();
    }

    private void Update()
    {
        playerhealth = FindAnyObjectByType<PlayerHealthbar>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {

        if(Time.time - lastAttackTime < attackCooldownTime)
        {
            return;
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            fight.SetBool("IsAttacking", true);
            playerhealth.TakeDamage(damage);
        }

        if (collision.gameObject.CompareTag("Tower"))
        {
            fight.SetBool("IsAttacking", true);
            towerhealth.TakeDamage(damage);
        }

        lastAttackTime = Time.time;
    }

}
