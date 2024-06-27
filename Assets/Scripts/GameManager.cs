using UnityEngine;
using UnityEngine.UI; // For UI elements (if needed)

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton instance
    private int enemiesKilled = 0; // Counter for enemies killed
    public int winCondition = 10; // Number of enemies to kill to win the game
  

    //public VictoryScreen victoryScreen;


    void Awake()
    {
        // Ensure there's only one instance of the GameManager
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Method to increment the enemies killed counter
    public void EnemyKilled()
    {
        enemiesKilled++;
        if (enemiesKilled >= winCondition)
        {

            //victoryScreen.ActiveScreen();

            Time.timeScale = 0f;
        }
    }
}

