using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KolonkaPlace : MonoBehaviour
{
    public Button yourButton;
    public GameObject kolonka;
    public GameObject plane;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        

    }

    void TaskOnClick()
    {
        kolonka.SetActive(true);
        plane.SetActive(true);
    }
}