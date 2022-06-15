using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class microPlace : MonoBehaviour
{
    public Button yourButton;
    public GameObject micro;


    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        micro.SetActive(false);
      

    }

    void TaskOnClick()
    {
        micro.SetActive(true);
            
    }
}
