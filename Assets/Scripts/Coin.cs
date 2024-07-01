using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{

    public int coinValue = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CollectCoin();
           GameManager.Instance.IncreaseCoins(coinValue);

        }
    }

    private void CollectCoin()
    {

        Destroy(gameObject);


    }
}