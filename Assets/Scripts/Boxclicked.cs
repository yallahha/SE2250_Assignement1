using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxclicked : MonoBehaviour
{

    public GameObject ground;
    void Start()
    {
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.parent.name == ground.name)
                {
                    // the object identified by hit.transform was clicked
                    // do whatever you want
                    Debug.Log("I was hit");
                    Vector3 rotate1 = new Vector3(ground.transform.eulerAngles.x, 5, 2);
                    ground.transform.Rotate(rotate1);
                    
                }
                    //{
                   // ground.transform.position = new Vector3(ground.transform.eulerAngles.x, 44, ground.transform.eulerAngles.z);
                    //    Debug.Log(orobject.transform.position);
                    //}
                    //else
                    //{
                    //  Debug.Log("Nothing");
                    //}
                }
            }
        }
    }

