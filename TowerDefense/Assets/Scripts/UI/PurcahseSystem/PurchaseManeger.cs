using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseManeger : MonoBehaviour
{

    public Button buyKnight;
    public Button buyDragon;
    public Button buyTurret;
    private GainGold gaingold;

    
    


    private void Start()
    {
        buyKnight.enabled = true;
        buyDragon.enabled = true;

        gaingold = GetComponent<GainGold>();
      
    }

    private void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length >= 4 )
        {
          buyKnight.enabled = false;
          buyDragon.enabled = false;

        }

        if (GameObject.FindGameObjectsWithTag("Player").Length <= 4)
        {
            buyKnight.enabled = true;
            buyDragon.enabled = true;
        }

        if (GameObject.FindGameObjectsWithTag("Turret").Length >= 1)
        {
            buyTurret.enabled = false;
        }





    }
}
