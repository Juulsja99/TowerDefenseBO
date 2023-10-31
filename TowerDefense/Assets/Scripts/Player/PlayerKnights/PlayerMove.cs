using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private bool collision = false; 
    public float speed = 2f;
    public Animator walkAni;
    

    // Start is called before the first frame update
    void Start()
    {
        GameObject tower = GameObject.FindGameObjectWithTag("Tower");
        Physics2D.IgnoreCollision(tower.GetComponent<Collider2D>(), GetComponent<Collider2D>());
       
    }

    // Update is called once per frame
    void Update()
    {
        if(collision == false)
        {
            Move();
        }
        
        
    }

    public void Move()
    {
        walkAni.SetFloat("Speed", 2);
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Enemy") || col.gameObject.CompareTag("Player"))
        {
            walkAni.SetFloat("Speed", 1);
            collision = true;
            Debug.Log("Coll");
        }
       



    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Enemy") || col.gameObject.CompareTag("Player"))
        {
            collision = false;
        }
    }
}

