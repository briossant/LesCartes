using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CreateCards : MonoBehaviour
{
    public GameObject cardPrefab;
    public Transform cam;

    public GameObject parentOfCards;
    public float rotationSpeed = 10f;
    
    public int cardNbr = 1;
    public float spawnDistance = 3f;

    private List<GameObject> objs = new List<GameObject>();

    private int rotDir = 1;

    public void SpawnCards()
    {
        foreach (var g in objs)
        {
            Destroy(g);
        }

        objs = new List<GameObject>();
        rotDir *= -1;

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
            obg.transform.LookAt(cam.transform);
            obg.transform.parent = parentOfCards.transform;
            objs.Add(obg);
        }
    }
    
    
    void Start()
    {
        SpawnCards();
    }

    private void Update()
    {
        parentOfCards.transform.position = cam.transform.position;
        parentOfCards.transform.Rotate(0,  rotationSpeed * Time.deltaTime * rotDir, 0);
        foreach (var g in objs)
        {
            g.transform.LookAt(cam.transform);
        }
    }
}
