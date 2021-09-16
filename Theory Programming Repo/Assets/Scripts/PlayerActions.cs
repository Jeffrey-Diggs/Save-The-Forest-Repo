using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    private EnemiesSpawner m_EnemiesSpawnerScript;
    public GameObject fxExplosion;
    public float camSpeed = 25.0f;
    void Start()
    {
        m_EnemiesSpawnerScript = GameObject.Find("Enemies Spawner").GetComponent<EnemiesSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        float vAxis = Input.GetAxis("Vertical");
        float hAxis = Input.GetAxis("Horizontal");
        if (vAxis != 0)
            Camera.main.transform.Translate(Vector3.forward * vAxis * Time.deltaTime * camSpeed);
        if (hAxis != 0)
            Camera.main.transform.Translate(Vector3.right * hAxis * Time.deltaTime * camSpeed);

        KeepCamInBounds();

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 400.0f))
            {
                if (hit.transform.CompareTag("Enemy"))
                {
                    Instantiate(fxExplosion, hit.transform.position, Quaternion.identity);
                    Destroy(hit.transform.gameObject);
                    m_EnemiesSpawnerScript.totalEnemies--;
                }
            }
        }
    }

    void KeepCamInBounds()
    {
        if (Camera.main.transform.position.x < -36)
            Camera.main.transform.position = new Vector3(-36, transform.position.y, transform.position.z);
        if (Camera.main.transform.position.x > 35)
            Camera.main.transform.position = new Vector3(35, transform.position.y, transform.position.z);

        if (Camera.main.transform.position.z < -75)
            Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, -75);
        if (Camera.main.transform.position.z > -48)
            Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, -48);


        if (Camera.main.transform.position.y < 13)
            Camera.main.transform.position = new Vector3(transform.position.x, 13, transform.position.z);
        if (Camera.main.transform.position.y > 28)
            Camera.main.transform.position = new Vector3(transform.position.x, 28, transform.position.z);
    }
}
