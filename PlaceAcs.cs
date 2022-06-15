using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceAcs : MonoBehaviour
{ 
    public GameObject trueacsbox;
    public GameObject trueacs;
    public Button yourButton;
    public GameObject intrf;
    public Camera cam12;
    public static int AcsPlace = 0;

    public Button yourButton4;
    public GameObject camera5;
    public GameObject camera6;


    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
   
        Button btn4 = yourButton4.GetComponent<Button>();
        btn4.onClick.AddListener(TaskOnClick4);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;

            Ray ray = cam12.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "mark")
                {
                    Debug.Log("CorrectMhukouiyuic2-");
                    trueacs.SetActive(true);
                    AcsPlace++;
                    trueacsbox.SetActive(true);
                }
             
            }

        }
    }

    void TaskOnClick()
    {
        intrf.SetActive(false);

    }
    void TaskOnClick4()
    {

            camera5.SetActive(false);
            camera6.SetActive(true);

    }
}


