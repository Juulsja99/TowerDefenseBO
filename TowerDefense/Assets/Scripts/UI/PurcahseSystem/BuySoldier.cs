using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuySoldier : MonoBehaviour
{
    public GameObject soldierPrefab;
    public GameObject Spawnpoint;
    [SerializeField] private GainGold gainGold;
    [SerializeField] private int cost = 2;


    private void Start()
    {
        gainGold = FindAnyObjectByType<GainGold>();

    }

    public void PurchaseSoldier()
    {
        if(gainGold.gold >= cost)
        {
            gainGold.SpendGold(cost);
            Instantiate(soldierPrefab, Spawnpoint.transform.position, Quaternion.identity);

        }


    }

   
}
