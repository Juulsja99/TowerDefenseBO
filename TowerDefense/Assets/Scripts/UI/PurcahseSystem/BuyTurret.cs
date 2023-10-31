using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyTurret : MonoBehaviour
{
    public GameObject TurretPrefab;
    public GameObject TurretSpawnpoint;
    [SerializeField] private GainGold gainGold;
    [SerializeField] private int cost = 20;


    private void Start()
    {
        gainGold = FindAnyObjectByType<GainGold>();

    }



    public void PurchaseTurret()
    {
        if (gainGold.gold >= cost)
        {
            gainGold.SpendGold(cost);
            Instantiate(TurretPrefab, TurretSpawnpoint.transform.position, Quaternion.identity);
        }
           


    }
}
