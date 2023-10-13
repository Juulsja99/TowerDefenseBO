using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShoot : MonoBehaviour
{
    public GameObject Bullet;
    public Transform BulletPosition;
    private float Timer;
    private GameObject player;

    private void Update()
    {
        Timer += Time.deltaTime;

        if(Timer > 3) 
        {
            Timer = 0;
            Shoot();

        }
    }

    void Shoot()
    {
        Instantiate(Bullet, BulletPosition.position, Quaternion.identity);
    }
}
