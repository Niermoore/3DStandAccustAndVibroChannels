using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class camswitch : MonoBehaviour
{
	public GameObject HideButton1;
	
	public GameObject Button2;
	public GameObject HideButton2;
	public GameObject HideButton3;
	public GameObject HideButton4;

	public GameObject Buttn;
	public GameObject button14;
	public GameObject button15;

	public GameObject VibrButton;
	public GameObject VibrIntr;

	public GameObject nHideButton6;
	public GameObject nHideButton7;
	public GameObject HideObj1;
	public GameObject HideObj2;
	public GameObject HideObj3;
	public GameObject HideAllIntr;

	public GameObject NHideButton8;

	public GameObject Line;
	public GameObject camera1;
	public GameObject camera2;
	public GameObject camera3;
	public GameObject camera4;
	public GameObject camera5;
	public GameObject camera6;

	public Button yourButton;
	public Button yourButton2;
	public Button yourButton3;
	public Button yourButton0;

	bool keyPress = false;
	public static bool keyPress1 = false;
	bool keyPress2 = false;
	bool keyPress11 = false;
	public Dropdown Dropdown;
	public GameObject HideEl;
	public GameObject metka;
	public GameObject coldoor;



	void Start()
	{
		
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		camera1.SetActive(true);
		camera2.SetActive(false);
		Button btn1 = yourButton2.GetComponent<Button>();
		btn1.onClick.AddListener(TaskOnClick1);
		camera3.SetActive(false);
		Button btn2 = yourButton0.GetComponent<Button>();
		btn2.onClick.AddListener(TaskOnClick2);
		Button2.SetActive(false);
		Button btn3 = yourButton3.GetComponent<Button>();
		btn3.onClick.AddListener(TaskOnClick3);
		HideButton4.SetActive(false);
	



    }

	void Update()
	{
		Screen.fullScreen = false;
		Screen.SetResolution(1920, 1080, false);
		if (Example.k == 1 && Example.l == 0)
		{ Button2.SetActive(true); }
		

	}
	
	void TaskOnClick()
	{
		if (keyPress == false)
		{
			camera1.SetActive(false);
			camera2.SetActive(true);
			keyPress = true;
			HideButton1.SetActive(false);
			HideEl.SetActive(false);
		}
	
	}

	void TaskOnClick1()
	{
		if (keyPress1 == false)
		{
			if (Dropdown.value == 0)
			{
				camera1.SetActive(false);
				camera3.SetActive(true);
				keyPress1 = true;
				HideButton1.SetActive(false);
				HideButton2.SetActive(false);
				HideEl.SetActive(false);
				Buttn.SetActive(false);
			}
			if (Dropdown.value == 1)
			{
				camera1.SetActive(false);
				camera5.SetActive(true);
				keyPress11 = true;
				HideButton1.SetActive(false);
				HideButton2.SetActive(false);
				HideButton3.SetActive(false);
				HideEl.SetActive(false);
				coldoor.SetActive(false);

				HideObj1.SetActive(false);
				HideObj2.SetActive(false);
				HideObj3.SetActive(false);
		
				nHideButton6.SetActive(true);
				nHideButton7.SetActive(true);
				
				NHideButton8.SetActive(true);
				VibrIntr.SetActive(true);
				metka.SetActive(true);
				Buttn.SetActive(false);
			}
			Line.SetActive(true);
			
		}
	}
	void TaskOnClick2()
	{
		if (Dropdown.value == 1)
		{ camera1.SetActive(true);
			camera3.SetActive(false);
			
		}
		if (keyPress1 == true)
		{
			camera3.SetActive(false);
			camera1.SetActive(true);
			keyPress1 = false;
			
		}
		if (keyPress == true)
		{
			camera2.SetActive(false);
			camera1.SetActive(true);
			keyPress = false;
			
		}
		if (keyPress2 == true)
		{
			camera4.SetActive(false);
			camera1.SetActive(true);
			if (CheckAcust1.CheckAcust > 0) { VibrButton.SetActive(true); }
			keyPress2 = false;
			HideEl.SetActive(true);

		}
			if (keyPress11 == true)
			{
				camera5.SetActive(false);
				camera1.SetActive(true);
				keyPress11 = false;
		
			
			}
			HideButton1.SetActive(true);
		if (Step2Place.CorrectMic1 > 0 && Step2PlaceMic2.CorrectMic2 > 0 && Step2Place3.CorrectSpeaker > 0 && Step2Place4.CorrectGenerator > 0 && Step2Place5.CorrectMetr > 0)
		{ HideButton3.SetActive(true);
			 }
		if (Step2Place.CorrectMic1 > 0 && Step2Place3.CorrectSpeaker > 0 && Step2Place4.CorrectGenerator > 0 && Step2Place5.CorrectMetr > 0)
		{
			HideAllIntr.SetActive(false);
			HideButton3.SetActive(true);
			
		}

	
		Line.SetActive(false);

	}
	void TaskOnClick3()
	{
		camera1.SetActive(false);
		camera4.SetActive(true);
		HideButton4.SetActive(true);
		if (Dropdown.value == 1)
		{
			button14.SetActive(false);
			button15.SetActive(true);
		}
		keyPress2 =true;
		HideEl.SetActive(false);

	}

}

 