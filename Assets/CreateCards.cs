using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCards : MonoBehaviour
{
    public GameObject cardPrefab;
    public Transform cam;

    public int cardNbr = 1;
    public float spawnDistance = 3f;

    private List<GameObject> objs = new List<GameObject>();

    public void SpawnCards()
    {
        foreach (var g in objs)
        {
            Destroy(g);
        }
        objs = new List<GameObject>();

        float trigo = 2 * Mathf.PI / cardNbr;
        int selectedToBeLaBonne = Random.Range(0, cardNbr);
        for (int i = 0; i < cardNbr; i++)
        {
            float x = cam.transform.position.x + spawnDistance * Mathf.Cos(trigo*i);
            float y = cam.transform.position.y;
            float z = cam.transform.position.z + spawnDistance * Mathf.Sin(trigo*i); 
            var obg = Instantiate(cardPrefab, new Vector3(x, y, z), Quaternion.identity); // LaBonne
            if (selectedToBeLaBonne == i)
            {
                obg.name = "LaBonne";
            }
            objs.Add(obg);
        }
    }
    
    
    void Start()
    {
        SpawnCards();
    }
}
