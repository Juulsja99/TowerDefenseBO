using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private bool collision = false;
    public float speed = -2f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (collision == false)
        {
            Move();
        }


    }

    public void Move()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        collision = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        collision = false;
    }
}

