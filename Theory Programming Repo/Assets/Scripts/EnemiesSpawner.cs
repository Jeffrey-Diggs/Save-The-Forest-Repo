using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    private GameObject[] spawnersLocationsArray;
    private GameObject[] m_enemiesArray;

    public int enemiesPerSpawn = 1;
    public int totalEnemies = 0;

    public UI_Display ui_DisplayScript;
    void Start()
    {
        spawnersLocationsArray = GameObject.FindGameObjectsWithTag("Spawner");
        m_enemiesArray = GameObject.FindGameObjectsWithTag("Enemy");
        SpawnEnemies(); // ABSTRACTION
    }

    void Update()
    {
    }

    public void SpawnEnemies()
    {
        foreach (var spawner in spawnersLocationsArray)
        {
            for (int i = 0; i < enemiesPerSpawn; i++)
            {
                int randomEnemy = Random.Range(0, m_enemiesArray.Length);
                Instantiate(m_enemiesArray[randomEnemy], spawner.transform.position, Quaternion.identity,spawner.transform);
                totalEnemies++;
            }
        }
    }
}
