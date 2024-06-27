using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab; 
    public float spawnInterval = 5f; 
    public float spawnRangeX = 10f; 
    public float spawnRangeY = 10f; 

  
    void Start()
    {
     
        StartCoroutine(SpawnEnemies());
    }

    // Coroutine to spawn enemies
    IEnumerator SpawnEnemies()
    {
        while (true)
        {
         
            yield return new WaitForSeconds(spawnInterval);

         
            Vector2 spawnPosition = new Vector2(
                Random.Range(-spawnRangeX, spawnRangeX),
                Random.Range(-spawnRangeY, spawnRangeY)
            );

     
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
