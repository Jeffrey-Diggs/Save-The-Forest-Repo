using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : Enemy // INHERITANCE
{
    private NavMeshAgent m_navMeshAgent;

    void Start()
    {
        m_navMeshAgent = GetComponent<NavMeshAgent>();
        m_navMeshAgent.speed = SetSpeed();
        PickAtree(); // ABSTRACTION
        GoToChosenTree(); // ABSTRACTION
    }

    public override float SetSpeed() // POLYMORPHISM
    {
        return 6.0f;
    }

    public GameObject PickAtree()
    {
        GameObject[] activeTrees = GameObject.FindGameObjectsWithTag("Tree");
        int randomTree = Random.Range(0, activeTrees.Length);
        return activeTrees[randomTree];
    }

    public void GoToChosenTree()
    {
        if (gameObject.transform.parent.name != "Prefab")
        {
            //m_navMeshAgent.speed = SetSpeed();
            m_navMeshAgent.SetDestination(PickAtree().transform.position);
        }
            
    }
}
