using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GainGold : MonoBehaviour
{
    public int gold;
    public Text GoldUI;



    private void Start()
    {
        gold = 5;
        Debug.Log(gold);
    }

    private void Update()
    {
        GoldUI.text = "Gold:" + gold;
    }

    public void GoldGained( int amount)
    {
        gold += amount;
        
    }

    public void SpendGold ( int amount ) 
    {
        gold -= amount;
    }

   
}
