using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step2Place5 : MonoBehaviour
{
    public GameObject plane;
    public Camera cam12;
    public static int CorrectMetr = 0;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;

            Ray ray = cam12.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (build5.correctPlaceMetr < 1)
                {
                    if (hit.transform.name == "CorrectPlaneMetr")
                    {
                        CorrectMetr++;
                        Debug.Log("CorrectMetr-" + CorrectMetr);
                        build5.correctPlaceMetr++;
                        plane.SetActive(false);
                    }
                }


            }

        }
    }
}
