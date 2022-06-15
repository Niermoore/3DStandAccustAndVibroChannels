using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Check1 : MonoBehaviour
{
	
	public Button yourButton;
	public GameObject yourButton1;
	public GameObject alert;
	public GameObject alert1;
	public GameObject SuccessText;
	public GameObject KTText;
	public GameObject MarkTrue;
	public GameObject[] marks;
	public GameObject MarkZone;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	
	}

	void TaskOnClick()
	{
		
		if (Example.k==1 && Example.l==0) 
		{
			Destroy(yourButton1.gameObject);
			SuccessText.SetActive(true);
			KTText.SetActive(true);
			MarkTrue.SetActive(true);
			MarkZone.SetActive(false);

			marks = GameObject.FindGameObjectsWithTag("Marks");
			foreach (GameObject element in marks)
			{
				Destroy(element);
			}
		}
        else if(Example.k == 0 && Example.l > 0)
        {
			alert.SetActive(true);
		}
		else if (Example.k > 0 && Example.l > 0)
		{
			alert.SetActive(true);
		}
		else if (Example.k > 0 && Example.l == 0)
		{
			alert.SetActive(true);
		}
		else if (Example.k == 0 && Example.l == 0)
		{
			alert1.SetActive(true);
		}
	}
}


