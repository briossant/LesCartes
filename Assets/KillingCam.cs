using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KillingCam : MonoBehaviour
{
    public GameObject particlesEff;
    private Vector2 touchpos;
    [SerializeField] private ApplicationManager tuto;
    private RaycastHit hit;
    private Camera cam;
    
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        bool victory = false;
        if (Input.touchCount <= 0)
        {
            return;
        }

        touchpos = Input.GetTouch(0).position;
        Ray ray = cam.ScreenPointToRay(touchpos);

        if (Physics.Raycast(ray, out hit))
        {
            GameObject hitobj = hit.collider.gameObject;
            if (hitobj.tag == "Enemy")
            {
                var clone = Instantiate(particlesEff, hitobj.transform.position, Quaternion.identity);
                clone.transform.localScale = hitobj.transform.localScale;
                if (hitobj.name == "LaBonne")
                {
                    victory = true;
                }
                Destroy(hitobj);
            }
        }

        if (victory)
        {
            Victory();
        }
        else
        {
            Die();
        }
    }

    void Victory()
    {
        Debug.Log("Victory");
        tuto.enemyNbr += 1;
        tuto.SpawnEnemy();
    }
    void Die()
    {
        Debug.Log("Death");
        tuto.enemyNbr = 1;
        tuto.SpawnEnemy();
    }
}
