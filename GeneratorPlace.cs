using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GeneratorPlace : MonoBehaviour
{
    public Button yourButton;
    public GameObject generator;
    public GameObject plane;
    public GameObject alert;
    public GameObject line;
    public GameObject lineText;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        generator.SetActive(true);
        plane.SetActive(true);
        alert.SetActive(true);
        line.SetActive(false);
        lineText.SetActive(false);
    }
}
