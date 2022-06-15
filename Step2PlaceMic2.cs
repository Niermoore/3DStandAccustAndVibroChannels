using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Step2PlaceMic2 : MonoBehaviour
{
    public Dropdown Dropdown;
    public GameObject plane3;
    public GameObject button;
    public GameObject button11;
    public Camera cam12;
    public static int CorrectMic2 = 0;
    public static int NotCorrectMic2 = 0;

    void Update()
    {
        if (Dropdown.value == 0){
            if (Input.GetMouseButton(0))
            {
                RaycastHit hit;

                Ray ray = cam12.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == "CorrectPlane2")
                    {
                        if (build2.correctPlaceMic2 < 1)
                        {

                            CorrectMic2++;

                            Debug.Log("CorrectMic2-" + CorrectMic2);
                            build2.correctPlaceMic2++;
                            plane3.SetActive(false);
                            button.SetActive(true);
                        }
                    }
                    if (hit.transform.name == "ColPlane1")
                    {
                        if (build2.correctPlaceMic2 < 1)
                        {

                            NotCorrectMic2++;
                            Debug.Log("NotCorrectMic2-" + NotCorrectMic2);
                            build2.correctPlaceMic2++;
                            plane3.SetActive(false);
                            button.SetActive(true);
                        }

                    }

                }

            }
        }
        if (Dropdown.value == 1)
        {
            button11.SetActive(false);
            plane3.SetActive(false);
        }
    }
}
