using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private GameObject Enemy;
    public string TargetTag;
    public GameObject Bullet;
    private Rigidbody2D rb;
    public float force;
    private float timer;
    public AudioClip ouch;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Enemy = GameObject.FindGameObjectWithTag("Enemy");

        Vector3 direction = Enemy.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > 7) 
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == TargetTag)
        {
            AudioSource.PlayClipAtPoint(ouch, transform.position);
            Destroy(Enemy);
            Destroy(Bullet);
            
            
        }
    }
}
