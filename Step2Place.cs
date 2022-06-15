using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Step2Place : MonoBehaviour
{
    public Dropdown Dropdown;
    public GameObject plane1;
    public GameObject button;
    public GameObject button1;
    public Camera cam12;
    public static int CorrectMic1 = 0;
    public static int NotCorrectMic1 = 0;

    void Update()
    {
        
            if (Input.GetMouseButton(0))
            {
                RaycastHit hit;

                Ray ray = cam12.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == "CorrectPlane")
                    {
                        if (Building.correctPlaceMic1 < 1)
                        {

                            CorrectMic1++;
                            Debug.Log("CorrectMic1-" + CorrectMic1);
                            Building.correctPlaceMic1++;
                            plane1.SetActive(false);
                            button.SetActive(true);
                        if (Dropdown.value == 1)
                        {
                            button1.SetActive(true);
                        }
                    }
                    }
                    if (hit.transform.name == "ColPlane")
                    {
                        if (Building.correctPlaceMic1 < 1)
                        {

                            NotCorrectMic1++;
                            Debug.Log("NotCorrectMic1-" + NotCorrectMic1);
                            Building.correctPlaceMic1++;
                            plane1.SetActive(false);
                            button.SetActive(true);
                            if (Dropdown.value == 1)
                            {
                                button1.SetActive(true);
                            }
                        }
                    }

                }

            }
        
       
    }
}