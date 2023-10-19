using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShoot : MonoBehaviour
{
    public GameObject Bullet;
    public Transform BulletPosition;
    public float Timer;
    public AudioSource Cannon;
  
    public  void Shoot()
    {

        Instantiate(Bullet, BulletPosition.position, Quaternion.identity);
        Cannon.Play();

        
       
    }
}
