using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    private EnemiesSpawner m_EnemiesSpawnerScript;
    public GameObject fxExplosion;
    void Start()
    {
        m_EnemiesSpawnerScript = GameObject.Find("Enemies Spawner").GetComponent<EnemiesSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 400.0f))
            {
                if (hit.transform.CompareTag("Enemy"))
                {
                    Instantiate(fxExplosion, hit.transform.position,Quaternion.identity);
                    Destroy(hit.transform.gameObject);
                    m_EnemiesSpawnerScript.totalEnemies--;
                }
                    
            }
                
        }
    }
}
