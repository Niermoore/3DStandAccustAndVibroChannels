using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step2Place4 : MonoBehaviour
{
    public GameObject plane;
    public GameObject button;
    public Camera cam12;
    public static int CorrectGenerator = 0;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;

            Ray ray = cam12.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (build4.correctPlaceGenerator < 1)
                {
                    if (hit.transform.name == "CorrectPlaneGen")
                    {
                        CorrectGenerator++;
                        Debug.Log("CorrectGenerator-" + CorrectGenerator);
                        build4.correctPlaceGenerator++;
                        plane.SetActive(false);
                        button.SetActive(true);
                    }
                }

            }

        }
    }
}
