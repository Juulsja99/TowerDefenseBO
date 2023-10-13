using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuySoldier : MonoBehaviour
{
    public GameObject soldierPrefab;
    public GameObject Spawnpoint;

    private PurchaseManeger purchasemanager;


    private void Start()
    {
        purchasemanager= GetComponent<PurchaseManeger>();
    }


    public void PurchaseSoldier()
    {
        Instantiate(soldierPrefab, Spawnpoint.transform.position, Quaternion.identity);

       
    }

   
}
