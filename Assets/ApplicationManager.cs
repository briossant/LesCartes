using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform cam;

    public int enemyNbr = 10;
    public float spawnRange = 3f;


    public void SpawnEnemy()
    {
        for (int i = 0; i < enemyNbr; i++)
        {
            float x = cam.transform.position.x + Random.Range(-spawnRange, spawnRange);
            float y = cam.transform.position.y + Random.Range(-spawnRange, spawnRange);
            float z = cam.transform.position.z + Random.Range(-spawnRange, spawnRange); 
            Instantiate(enemyPrefab, new Vector3(x, y, z), Quaternion.identity);
        }
    }
    
    
    void Start()
    {
        SpawnEnemy();
    }


}
