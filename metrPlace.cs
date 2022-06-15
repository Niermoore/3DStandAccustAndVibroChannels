using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class metrPlace : MonoBehaviour
{
    public Button yourButton;
    public GameObject metr;
    public GameObject plane;
    public GameObject alert;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
       

    }

    void TaskOnClick()
    {
        metr.SetActive(true);
        plane.SetActive(true);
        alert.SetActive(true);
    }
}
