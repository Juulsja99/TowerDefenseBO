using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetting : MonoBehaviour
{
    private TurretShoot turretshoot;

    private void Start()
    {
        turretshoot= GetComponent<TurretShoot>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {
            turretshoot.Shoot();
            Debug.Log("Target");
        }
          
    }
}
