using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyDragon : MonoBehaviour
{
    public GameObject dragon;
    public GameObject Spawnpoint;
    [SerializeField] private GainGold gainGold;
    [SerializeField] private int cost = 5;


    private void Start()
    {
        gainGold = FindAnyObjectByType<GainGold>();

    }

    public void buyDragon()
    {
        if (gainGold.gold >= cost)
        {
            gainGold.SpendGold(cost);
            Instantiate(dragon, Spawnpoint.transform.position, Quaternion.identity);
        }
           
    }
}
