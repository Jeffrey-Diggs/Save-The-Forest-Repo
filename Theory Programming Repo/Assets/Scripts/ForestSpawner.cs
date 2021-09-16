using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestSpawner : MonoBehaviour
{
    private GameObject[] treesArray;
    private GameObject[] deadTreesArray;

    public int treesAmount { get; private set; } // ENCAPSULATION

    void Start()
    {
        treesArray = GameObject.FindGameObjectsWithTag("Tree");
        deadTreesArray = GameObject.FindGameObjectsWithTag("DeadTree");

        SpawnForest(); // ABSTRACTION
    }

    void Update()
    {
        
    }

    void SpawnForest()
    {
        treesAmount = Random.Range(80, 120);

        for (int i = 0; i < treesAmount; i++)
        {
            int randomTree = Random.Range(0, treesArray.Length);
            Instantiate(treesArray[randomTree], new Vector3(Random.Range(-24, 34), 0, Random.Range(-38, 33)), Quaternion.Euler(0, Random.Range(0, 360), 0));
        }
    }
}
