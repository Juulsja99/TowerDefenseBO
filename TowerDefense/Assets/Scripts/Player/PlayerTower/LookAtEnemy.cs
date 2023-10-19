using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtEnemy : MonoBehaviour
{
    [SerializeField] private Transform target;


    private void Start()
    {
        GameObject[] target = GameObject.FindGameObjectsWithTag("Enemy");
    }

    private void Update()
    {
        LookAtTarget();
    }

    void LookAtTarget()
    {
        Vector2 direction = target.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.right, direction);

    }
}
