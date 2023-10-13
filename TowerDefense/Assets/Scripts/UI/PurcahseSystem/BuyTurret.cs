using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyTurret : MonoBehaviour
{
    public GameObject TurretPrefab;
    public GameObject TurretSpawnpoint;

   


    public void PurchaseTurret()
    {
        Instantiate(TurretPrefab, TurretSpawnpoint.transform.position, Quaternion.identity);


    }
}
