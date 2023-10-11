using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyDragon : MonoBehaviour
{
    public GameObject dragon;
    public GameObject Spawnpoint;

    public void buyDragon()
    {
        Instantiate(dragon, Spawnpoint.transform.position, Quaternion.identity);
    }
}
