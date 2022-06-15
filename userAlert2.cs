using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class userAlert2 : MonoBehaviour
{

	public Button yourButton;
	public GameObject alert1;
	public GameObject mark;
	public GameObject[] marks;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

	}

	void TaskOnClick()
	{
		alert1.SetActive(false);
		Example.k = 0;
		Example.l = 0;
		mark.tag = "Untagged";
		marks = GameObject.FindGameObjectsWithTag("Marks");
		foreach (GameObject element in marks)
		{
			Destroy(element);
		}
		mark.tag = "Marks";
	}
}
