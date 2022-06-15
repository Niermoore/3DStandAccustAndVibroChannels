using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class userAlert5 : MonoBehaviour
{


	public Button yourButton;
	public GameObject alert;
	public GameObject button1;
	public GameObject button2;
	public GameObject button3;
	public GameObject button4;


	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		alert.SetActive(false);

	}

	void TaskOnClick()
	{
		alert.SetActive(false);
		
	}
}
