using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{

    public GameObject gameOverPanel;

    private void Start()
    {

        gameOverPanel.SetActive(false);
    }

    public void ActiveScreen()
    {

        gameOverPanel.SetActive(true);
        StartCoroutine(WaitForClickToRestart());
    }

    private IEnumerator WaitForClickToRestart()
    {
        while (!Input.GetMouseButtonDown(0)) 
        {
            yield return null;
        }
        RestartGame();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}