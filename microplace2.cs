using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class microplace2 : MonoBehaviour
{
    public Button yourButton;
    public GameObject micro;
    public GameObject plane;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        

    }

    void TaskOnClick()
    {
        micro.SetActive(true);
        plane.SetActive(true);
    }
}

