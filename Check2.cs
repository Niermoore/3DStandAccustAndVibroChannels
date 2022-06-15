using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Check2 : MonoBehaviour
{
	public GameObject micro;
	public GameObject kolonka;
	public GameObject generator;
	public GameObject metr;

	public GameObject Buuttn;

	public GameObject yourButton33;
	public Dropdown Dropdown1;
	public Dropdown Dropdown;
	public Button yourButton3;
	public Button yourButton;
	public GameObject yourButton1;
	public Button yourButton1111;
	public GameObject yourButton111;
	public GameObject SuccessText;
	public GameObject TrueObj1;
	public GameObject TrueObj2;
	public GameObject TrueObj3;
	public GameObject TrueObj4;
	public GameObject TrueObj5;
	public GameObject cables;
	public GameObject cables1;
	public GameObject NotTrueObj1;
	public GameObject NotTrueObj2;
	public GameObject NotTrueObj3;
	public GameObject NotTrueObj4;
	public GameObject NotTrueObj5;

	public GameObject button1;
	public GameObject button2;
	public GameObject button3;
	public GameObject button4;

	public GameObject suc1;
	public GameObject suc2;
	public GameObject suc3;
	public GameObject vb1;
	public GameObject vb2;
	public GameObject vb3;


	public GameObject alert;
	public GameObject alert2;
	public GameObject alert3;
	public GameObject plane;
	public GameObject line;
	public GameObject lineText;

	int FailCount = 0;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		Button btn1 = yourButton111.GetComponent<Button>();
		btn1.onClick.AddListener(TaskOnClick1);
		Button btn3 = yourButton3.GetComponent<Button>();
		btn3.onClick.AddListener(TaskOnClick3);
		micro.SetActive(false);
		kolonka.SetActive(false);
		generator.SetActive(false);
		metr.SetActive(false);

		button1.SetActive(false);
		button2.SetActive(false);
		button3.SetActive(false);
		button4.SetActive(false);
		

	}
	void TaskOnClick3()
	{
		
				if ( CheckAcust1.CheckAcust >0 && Dropdown1.value == 1)
				{
					Destroy(yourButton3.gameObject);
					NotTrueObj1.SetActive(false);
					NotTrueObj2.SetActive(false);
					NotTrueObj3.SetActive(false);
					NotTrueObj4.SetActive(false);
					NotTrueObj5.SetActive(false);
					TrueObj1.SetActive(false);
					TrueObj2.SetActive(false);
					TrueObj3.SetActive(false);
					TrueObj4.SetActive(false);
					TrueObj5.SetActive(false);
					cables.SetActive(false);

					button1.SetActive(false);
					button2.SetActive(false);
					button3.SetActive(false);
					button4.SetActive(false);


					if (Building.correctPlaceMic1 > 0)
					{
						Building.correctPlaceMic1--;

					}

					if (build2.correctPlaceMic2 > 0)
					{

						build2.correctPlaceMic2--;

					}
					if (build3.correctPlaceSpeaker > 0)
					{

						build3.correctPlaceSpeaker--;

					}
					if (build4.correctPlaceGenerator > 0)
					{

						build4.correctPlaceGenerator--;

					}
					if (build5.correctPlaceMetr > 0)
					{

						build5.correctPlaceMetr--;
					}

					if (Step2Place.CorrectMic1 > 0)
					{

						Step2Place.CorrectMic1--;
					}
					if (Step2Place.NotCorrectMic1 > 0)
					{

						Step2Place.NotCorrectMic1--;
					}
					if (Step2PlaceMic2.CorrectMic2 > 0)
					{

						Step2PlaceMic2.CorrectMic2--;
					}
					if (Step2PlaceMic2.NotCorrectMic2 > 0)
					{

						Step2PlaceMic2.NotCorrectMic2--;
					}
					if (Step2Place3.CorrectSpeaker > 0)
					{

						Step2Place3.CorrectSpeaker--;
					}
					if (Step2Place3.NotCorrectSpeaker > 0)
					{

						Step2Place3.NotCorrectSpeaker--;
					}
					if (Step2Place4.CorrectGenerator > 0)
					{

						Step2Place4.CorrectGenerator--;
					}
					if (Step2Place5.CorrectMetr > 0)
					{

						Step2Place5.CorrectMetr--;
					}
				yourButton33.SetActive(false);
				plane.SetActive(true);
				line.SetActive(true);
				lineText.SetActive(true);

				suc1.SetActive(false);
				suc2.SetActive(false);
				suc3.SetActive(false);
				vb1.SetActive(true);
				vb2.SetActive(true);
				vb3.SetActive(true);
				}

			


			
	}
		void TaskOnClick()
		{
		
			if (Step2Place.CorrectMic1 > 0 && Step2PlaceMic2.CorrectMic2 > 0 && Step2Place3.CorrectSpeaker > 0 && Step2Place4.CorrectGenerator > 0 && Step2Place5.CorrectMetr > 0)
			{
				Destroy(yourButton1.gameObject);
				SuccessText.SetActive(true);

				NotTrueObj1.SetActive(false);
				NotTrueObj2.SetActive(false);
				NotTrueObj3.SetActive(false);
				NotTrueObj4.SetActive(false);
				NotTrueObj5.SetActive(false);

				TrueObj1.SetActive(true);
				TrueObj2.SetActive(true);
				TrueObj3.SetActive(true);
				TrueObj4.SetActive(true);
				TrueObj5.SetActive(true);
				cables.SetActive(true);
				Buuttn.SetActive(true);




		}
			else if (Step2Place.CorrectMic1 == 0 && Step2PlaceMic2.CorrectMic2 == 0 && Step2Place3.CorrectSpeaker == 0 && Step2Place4.CorrectGenerator == 0 && Step2Place5.CorrectMetr == 0 && Step2Place.NotCorrectMic1 == 0 && Step2PlaceMic2.NotCorrectMic2 == 0 && Step2Place3.NotCorrectSpeaker == 0)
			{ alert3.SetActive(true); }
			else
			{


				NotTrueObj1.SetActive(false);
				NotTrueObj2.SetActive(false);
				NotTrueObj3.SetActive(false);
				NotTrueObj4.SetActive(false);
				NotTrueObj5.SetActive(false);

				button1.SetActive(false);
				button2.SetActive(false);
				button3.SetActive(false);
				button4.SetActive(false);


				if (Building.correctPlaceMic1 > 0)
				{
					Building.correctPlaceMic1--;

				}

				if (build2.correctPlaceMic2 > 0)
				{

					build2.correctPlaceMic2--;

				}
				if (build3.correctPlaceSpeaker > 0)
				{

					build3.correctPlaceSpeaker--;

				}
				if (build4.correctPlaceGenerator > 0)
				{

					build4.correctPlaceGenerator--;

				}
				if (build5.correctPlaceMetr > 0)
				{

					build5.correctPlaceMetr--;
				}

				if (Step2Place.CorrectMic1 > 0)
				{

					Step2Place.CorrectMic1--;
				}
				if (Step2Place.NotCorrectMic1 > 0)
				{

					Step2Place.NotCorrectMic1--;
				}
				if (Step2PlaceMic2.CorrectMic2 > 0)
				{

					Step2PlaceMic2.CorrectMic2--;
				}
				if (Step2PlaceMic2.NotCorrectMic2 > 0)
				{

					Step2PlaceMic2.NotCorrectMic2--;
				}
				if (Step2Place3.CorrectSpeaker > 0)
				{

					Step2Place3.CorrectSpeaker--;
				}
				if (Step2Place3.NotCorrectSpeaker > 0)
				{

					Step2Place3.NotCorrectSpeaker--;
				}
				if (Step2Place4.CorrectGenerator > 0)
				{

					Step2Place4.CorrectGenerator--;
				}
				if (Step2Place5.CorrectMetr > 0)
				{

					Step2Place5.CorrectMetr--;
				}







				Debug.Log(Building.correctPlaceMic1);
				Debug.Log(build2.correctPlaceMic2);
				Debug.Log(build3.correctPlaceSpeaker);
				Debug.Log(build4.correctPlaceGenerator);
				Debug.Log(build5.correctPlaceMetr);



				plane.SetActive(true);
				line.SetActive(true);
				lineText.SetActive(true);

				if (FailCount == 0)
				{
					alert.SetActive(true);
					FailCount++;
				}
				else
				{
					alert2.SetActive(true);
					FailCount--;
				}



			
			}

		
	}
	void TaskOnClick1()
	{
	
		
		
			if (Step2Place.CorrectMic1 > 0  && Step2Place3.CorrectSpeaker > 0 && Step2Place4.CorrectGenerator > 0 && Step2Place5.CorrectMetr > 0)
			{
				Destroy(yourButton111.gameObject);
				SuccessText.SetActive(true);

				NotTrueObj1.SetActive(false);
				
				NotTrueObj3.SetActive(false);
				NotTrueObj4.SetActive(false);
				NotTrueObj5.SetActive(false);

				TrueObj1.SetActive(true);
		
				TrueObj3.SetActive(true);
				TrueObj4.SetActive(true);
				TrueObj5.SetActive(true);
				cables1.SetActive(true);
				Buuttn.SetActive(true);



		}
			else if (Step2Place.CorrectMic1 == 0  && Step2Place3.CorrectSpeaker == 0 && Step2Place4.CorrectGenerator == 0 && Step2Place5.CorrectMetr == 0 && Step2Place.NotCorrectMic1 == 0 && Step2PlaceMic2.NotCorrectMic2 == 0 && Step2Place3.NotCorrectSpeaker == 0)
			{ alert3.SetActive(true); }
			else
			{


				NotTrueObj1.SetActive(false);
				
				NotTrueObj3.SetActive(false);
				NotTrueObj4.SetActive(false);
				NotTrueObj5.SetActive(false);

				button1.SetActive(false);
				button2.SetActive(false);
				button3.SetActive(false);
				button4.SetActive(false);


				if (Building.correctPlaceMic1 > 0)
				{
					Building.correctPlaceMic1--;

				}

				if (build2.correctPlaceMic2 > 0)
				{

					build2.correctPlaceMic2--;

				}
				if (build3.correctPlaceSpeaker > 0)
				{

					build3.correctPlaceSpeaker--;

				}
				if (build4.correctPlaceGenerator > 0)
				{

					build4.correctPlaceGenerator--;

				}
				if (build5.correctPlaceMetr > 0)
				{

					build5.correctPlaceMetr--;
				}

				if (Step2Place.CorrectMic1 > 0)
				{

					Step2Place.CorrectMic1--;
				}
				if (Step2Place.NotCorrectMic1 > 0)
				{

					Step2Place.NotCorrectMic1--;
				}
				
				if (Step2Place3.CorrectSpeaker > 0)
				{

					Step2Place3.CorrectSpeaker--;
				}
				if (Step2Place3.NotCorrectSpeaker > 0)
				{

					Step2Place3.NotCorrectSpeaker--;
				}
				if (Step2Place4.CorrectGenerator > 0)
				{

					Step2Place4.CorrectGenerator--;
				}
				if (Step2Place5.CorrectMetr > 0)
				{

					Step2Place5.CorrectMetr--;
				}







				Debug.Log(Building.correctPlaceMic1);
				Debug.Log(build3.correctPlaceSpeaker);
				Debug.Log(build4.correctPlaceGenerator);
				Debug.Log(build5.correctPlaceMetr);



				plane.SetActive(true);
				line.SetActive(true);
				lineText.SetActive(true);

				if (FailCount == 0)
				{
					alert.SetActive(true);
					FailCount++;
				}
				else
				{
					alert2.SetActive(true);
					FailCount--;
				}



			
		}


	}
}



