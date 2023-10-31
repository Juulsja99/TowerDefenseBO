using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower1Health : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;
    public GameObject StateUI;
    public static bool YouWon = false;



    void Start()
    {
        currentHealth = maxHealth;
    }


    void Update()
    {
        if (currentHealth <= 0)
        {
            Win();
        }
        else
        {
            Resume();
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

    }

    void Win()
    {
        StateUI.SetActive(true);
        Time.timeScale = 0f;
        YouWon = true;
    }

    void Resume()
    {
        StateUI.SetActive(false);
        Time.timeScale = 1f;
        YouWon = false;
    }
}
