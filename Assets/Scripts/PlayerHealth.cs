using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    //public HealthBar healthBar;

    public GameOverScreen gameOverScreen;

    public Image borderImage; // The red border image
    public Image healthImage; // The green health bar image

    private void Start()
    {

        currentHealth = maxHealth;
        UpdateHealthBar();

    }


    public void TakeDamage(int damageAmount)
    {
        Debug.Log("Damage!");
        currentHealth -= damageAmount;
        UpdateHealthBar();

        if (currentHealth <= 0)
        {

            gameOverScreen.ActiveScreen();

        }
    }
    private void UpdateHealthBar()
    {
        float healthPercent = (float)currentHealth / maxHealth;
        healthImage.fillAmount = healthPercent;
    }
}