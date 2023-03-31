using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillingCam : MonoBehaviour
{
    public GameObject particlesEff;
    private Vector2 touchpos;

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
                Destroy(hitobj);
            }
        }
    }
}
