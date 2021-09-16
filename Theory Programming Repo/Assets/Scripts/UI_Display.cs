using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI_Display : MonoBehaviour
{
    public GameObject waveNumber;
    public GameObject waveNumberShadow;

    public GameObject treesCounter;
    public GameObject treesCounterShadow;

    public GameObject enemiesCounter;
    public GameObject enemiesCounterShadow;

    private ForestSpawner forestSpawnerScript;
    private EnemiesSpawner enemiesSpawnerScript;

    public int waveCount = 1;
    void Start()
    {
        forestSpawnerScript = GameObject.Find("Forest Spawner").GetComponent<ForestSpawner>();
        enemiesSpawnerScript = GameObject.Find("Enemies Spawner").GetComponent<EnemiesSpawner>();

        waveNumber.GetComponent<TextMeshProUGUI>().text = "Wave n° " + waveCount.ToString();
        waveNumberShadow.GetComponent<TextMeshProUGUI>().text = waveNumber.GetComponent<TextMeshProUGUI>().text;

    }

    void Update()
    {
        treesCounter.GetComponent<TextMeshProUGUI>().text = "Trees Left : " + forestSpawnerScript.treesAmount.ToString();
        treesCounterShadow.GetComponent<TextMeshProUGUI>().text = treesCounter.GetComponent<TextMeshProUGUI>().text;

        enemiesCounter.GetComponent<TextMeshProUGUI>().text = "Enemies : " + enemiesSpawnerScript.totalEnemies.ToString();
        enemiesCounterShadow.GetComponent<TextMeshProUGUI>().text = enemiesCounter.GetComponent<TextMeshProUGUI>().text;
    }
}
