using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeBehavior : MonoBehaviour
{
    private GameObject[] m_DeadTreesArray;
    private ForestSpawner forestSpawnerScript;
    void Start()
    {
        m_DeadTreesArray = GameObject.FindGameObjectsWithTag("DeadTree");
        forestSpawnerScript = GameObject.Find("Forest Spawner").GetComponent<ForestSpawner>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            EnemyBehavior enemyScript = other.gameObject.GetComponent<EnemyBehavior>();

            ReplaceWithDeadTree();
            enemyScript.PickAtree();
            enemyScript.GoToChosenTree();
        }
    }

    void ReplaceWithDeadTree()
    {
        int randomDeadTree = Random.Range(0, m_DeadTreesArray.Length);
        Instantiate(m_DeadTreesArray[randomDeadTree], transform.position, Quaternion.Euler(0, Random.Range(0, 360), 0));
        forestSpawnerScript.treesAmount--;
        Destroy(gameObject);
    }
}
