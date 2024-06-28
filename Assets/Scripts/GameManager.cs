using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    public static GameManager instance; 
    private int enemiesKilled = 0; 
    public int winCondition = 10;


    public VictoryScreen victoryScreen;


    void Awake()
    {
       
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

   
    public void EnemyKilled()
    {
        enemiesKilled++;
        if (enemiesKilled >= winCondition)
        {

            victoryScreen.ActiveScreen();

            Time.timeScale = 0f;
        }
    }
}

