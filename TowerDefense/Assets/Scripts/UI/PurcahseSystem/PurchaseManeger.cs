using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseManeger : MonoBehaviour
{

    public Button buyKnight;
    public Button buyDragon;
    


    private void Start()
    {
        buyKnight.enabled = true;
        buyDragon.enabled = true;
      
    }

    private void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length >= 5)
        {
          buyKnight.enabled = false;
          buyDragon.enabled = false;
            
        }

        if (GameObject.FindGameObjectsWithTag("Player").Length <= 5)
        {
            buyKnight.enabled = true;
            buyDragon.enabled = true;
            Debug.Log("BUY");
        }

    }
}
