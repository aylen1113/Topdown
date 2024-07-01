using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private int enemiesKilled = 0; 
    public int winCondition = 10;


    public VictoryScreen victoryScreen;

    public Text coinText;
    public int currentCoins;

    void Awake()
    {
       
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        coinText.text = "COINS: " + currentCoins.ToString();

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
    public void IncreaseCoins(int v)
    {
        currentCoins += v;
        coinText.text = "COINS: " + currentCoins.ToString();
    }

    public int GetCurrentCoins()
    {
        return currentCoins;
    }
}



