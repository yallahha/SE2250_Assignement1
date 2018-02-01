using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClicked : MonoBehaviour
{
    Vector3 orposition;
    public GameObject orobject;
    public GameObject ground;
   // public GameObject newobject;


    
    // Use this for initialization
    void Start()
    {
        orposition = orobject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray toMouse = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit sss;
            if (Physics.Raycast(toMouse, out sss))
            {
                if (sss.transform.name == orobject.name)
                {
                    //{
                    orobject.transform.position = orposition;
                    //    Debug.Log(orobject.transform.position);
                    //}
                    //else
                    //{
                    //  Debug.Log("Nothing");
                    //}
                }
                if (sss.transform.parent.name == ground.name)
                { 
                    Debug.Log("I was hit");
                    Vector3 rotate1 = new Vector3(ground.transform.eulerAngles.x, ground.transform.eulerAngles.y, 2);
                    ground.transform.Rotate(rotate1);  

                }
            }
        }
    }
}
