using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryScreen : MonoBehaviour
{
    public GameObject victoryPanel; 

    public void ActiveScreen()
    {
        if (victoryPanel != null)
        {
            victoryPanel.SetActive(true);
        }
    }
}
