using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private PlayerBehavior playerBehavior;
    [SerializeField] private GameObject enemyPrefab;

    public float spawnCooldown = 5f;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
        
    private IEnumerator SpawnEnemy()
    {
        if (playerBehavior.playerAlive)
        {
            yield return new WaitForSeconds(spawnCooldown);
            GameObject newEnemy = Instantiate(enemyPrefab, new Vector3(
                Random.Range(-5f, 5f), Random.Range(-6f, 6f), 0), Quaternion.identity);
            StartCoroutine(SpawnEnemy());
        }
    }
}
