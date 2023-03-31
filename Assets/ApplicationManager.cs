using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform cam;

    public int enemyNbr = 1;
    public float spawnRange = 3f;

    private List<GameObject> objs = new List<GameObject>();

    public void SpawnEnemy()
    {
        foreach (var g in objs)
        {
            Destroy(g);
        }
        objs = new List<GameObject>();

        float trigo = 2 * Mathf.PI / enemyNbr;
        int selectedToBeLaBonne = Random.Range(0, enemyNbr);
        for (int i = 0; i < enemyNbr; i++)
        {
            float x = cam.transform.position.x + spawnRange * Mathf.Cos(trigo*i);
            float y = cam.transform.position.y;
            float z = cam.transform.position.z + spawnRange * Mathf.Sin(trigo*i); 
            var obg = Instantiate(enemyPrefab, new Vector3(x, y, z), Quaternion.identity); // LaBonne
            if (selectedToBeLaBonne == i)
            {
                obg.name = "LaBonne";
            }
            objs.Add(obg);
        }
    }
    
    
    void Start()
    {
        SpawnEnemy();
    }
}
