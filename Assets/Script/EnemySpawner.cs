using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{

    [Header("References")]
    [SerializeField] private GameObject[] enemyPrefabs;
    [SerializeField] private GameObject bossPrefabs;


    [Header("Attributes")]
    [SerializeField] private int baseEnemies = 8;
    [SerializeField] private float enemiesPerSecond = 0.5f;
    [SerializeField] private float timeBetweenWaves = 5f;
    [SerializeField] private float difficultyScalingFactor = 0.75f;
    [SerializeField] private int bossEnemies = 1;

    [Header("Events")]
    public static UnityEvent onEnemyDestroy = new UnityEvent();

    private int currentWave = 1;
    private float timeSinceLastSpawn;
    private int enemiesAlive;
    private int enemiesLeftToSpawn;
    private bool isSpawning = false;

    private int countWave = 1;


    


    private void Awake()
    {
        onEnemyDestroy.AddListener(EnemyDestroyed);
    }
    private void Start()
    {
        StartCoroutine(StartWave());
    }
    private void Update()
    {
        if (!isSpawning) return;

        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= (1f / enemiesPerSecond) && enemiesLeftToSpawn > 0)
        {
            SpawnEnemy();
            
            enemiesLeftToSpawn--;
            enemiesAlive++;
            timeSinceLastSpawn = 0f;

            if (countWave == 3)
            {
                if (enemiesLeftToSpawn == 0 && enemiesAlive == 0)
                {
                    Time.timeScale = 0;

                    SceneManager.LoadScene(1);
                }
            }
        }

        if (enemiesAlive == 0 && enemiesLeftToSpawn == 0)
        {
            EndWave();
            countWave++;
            baseEnemies += 2;
        }
    }

    private void EnemyDestroyed()
    {
        enemiesAlive--;
    }
    private IEnumerator StartWave()
    {
        yield return new WaitForSeconds(timeBetweenWaves);
        isSpawning = true;
        enemiesLeftToSpawn = EnemiesPerWave();
    }

    private void EndWave()
    {
        isSpawning = false;
        timeSinceLastSpawn = 0f;
        StartCoroutine(StartWave());
    }
    private void SpawnEnemy()
    {
        GameObject prefabToSpawn = enemyPrefabs[0];
        Instantiate(prefabToSpawn, LevelManager.main.startPoint.position, Quaternion.identity);
        if (countWave == 3)
        {
            GameObject bossSpawn = bossPrefabs;
            Instantiate(prefabToSpawn, LevelManager.main.startPoint.position, Quaternion.identity);
        }
    }
    private int EnemiesPerWave()
    {
        return Mathf.RoundToInt(baseEnemies * Mathf.Pow(currentWave, difficultyScalingFactor));
    }
    
}
