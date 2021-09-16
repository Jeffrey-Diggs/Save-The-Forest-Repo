using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : Enemy
{
    private NavMeshAgent m_navMeshAgent;

    void Start()
    {
        m_navMeshAgent = GetComponent<NavMeshAgent>();

        PickAtree(); // ABSTRACTION
        GoToChosenTree(); // ABSTRACTION
    }

    GameObject PickAtree()
    {
        GameObject[] activeTrees = GameObject.FindGameObjectsWithTag("Tree");
        int randomTree = Random.Range(0, activeTrees.Length);
        return activeTrees[randomTree];
    }

    void GoToChosenTree()
    {
        if (gameObject.transform.parent.name != "Prefab")
            m_navMeshAgent.SetDestination(PickAtree().transform.position);
    }

}
