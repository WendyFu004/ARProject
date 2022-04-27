using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selected : MonoBehaviour
{
    public GameObject selectedObject;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    GameObject hitobj = hit.transform.root.gameObject;

                   
                    Color newcolor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f);
                    hitobj.GetComponent<MeshRenderer>().material.color = newcolor;

                    hitobj.GetComponent<ScaleandRatate>().applyslider = !hitobj.GetComponent<ScaleandRatate>().applyslider;

                    //selectObject(hitobj);
                }
                else
                {
                   // ClearSelection();
                }
            }
        }

    }
    public void selectObject(GameObject obj)
    {
        if (selectedObject != null)
        {
            if (obj == selectedObject)
            {
                return;
            }
            selectedObject = obj;
        }


        selectedObject.GetComponent<ScaleandRatate>().applyslider = true;
    }
    void ClearSelection()
    {
        if (selectedObject = null)
            return;

        selectedObject.GetComponent<ScaleandRatate>().applyslider = false;
    }

}
