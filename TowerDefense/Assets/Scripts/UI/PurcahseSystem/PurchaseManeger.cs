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
    public GameObject PurchasePanel;
    private TowerHealth towerhealth;

    
    


    private void Start()
    {
        buyKnight.enabled = true;
        buyDragon.enabled = true;

        gaingold = GetComponent<GainGold>();
        towerhealth = FindAnyObjectByType<TowerHealth>();
      
    }

    private void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length >= 4)
        {
          buyKnight.enabled = false;
          buyDragon.enabled = false;

        }
        else
        {
            buyKnight.enabled = true;
            buyDragon.enabled = true;
        }

        

        if (GameObject.FindGameObjectsWithTag("Turret").Length >= 1)
        {
            buyTurret.enabled = false;
        }

       if(towerhealth.currentHealth <= 0)
        {
            PurchasePanel.SetActive(false);
        }
        else
        {
            PurchasePanel.SetActive(true);
        }

    }


}
