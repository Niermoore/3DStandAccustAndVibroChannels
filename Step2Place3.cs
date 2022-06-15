using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step2Place3 : MonoBehaviour
{
    public GameObject plane3;
    public GameObject button;
    public Camera cam12;
    public static int CorrectSpeaker = 0;
    public static int NotCorrectSpeaker = 0;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;

            Ray ray = cam12.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "CorrectPlane3")
                {
                    if (build3.correctPlaceSpeaker < 1)
                    {
                      
                         CorrectSpeaker++; 
                        Debug.Log("CorrectSpeaker-" + CorrectSpeaker);
                        build3.correctPlaceSpeaker++;
                        plane3.SetActive(false);
                        button.SetActive(true);
                    }
                }
                if (hit.transform.name == "ColPlane2")
                {
                    if (build3.correctPlaceSpeaker < 1)
                    {
                       
                         NotCorrectSpeaker++; 
                        Debug.Log("NotCorrectSpeaker-" + NotCorrectSpeaker);
                        build3.correctPlaceSpeaker++;
                        button.SetActive(true);
                        plane3.SetActive(false);
                    }
                }

            }

        }
    }
}