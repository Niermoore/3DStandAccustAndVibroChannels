using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class userAlert3s5 : MonoBehaviour
{
	
	public Button yourButton;
	public GameObject alert;


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