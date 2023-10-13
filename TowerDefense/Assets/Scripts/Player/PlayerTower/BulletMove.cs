using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private GameObject Enemy;
    private Rigidbody2D rb;
    public float force;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Enemy = GameObject.FindGameObjectWithTag("Enemy");

        Vector3 direction = Enemy.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
    }
}
