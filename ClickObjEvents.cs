using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickObjEvents : MonoBehaviour
{
    public Button yourButton;
    public GameObject button;
    public Button yourButton2;
    public GameObject button2;
    public Button yourButton3;

    public Button yourButton33;
    public GameObject AlertRez;



    public Button yourButton6;
    public Button yourButton7;
    public GameObject button6;
    public GameObject button7;
    public Button yourButton8;
    public Button yourButton9;
    public Button yourButton10;
    public Button yourButton11;
    public Button yourButton12;
    public Button yourButton13;
    public Button yourButton14;
    public Button yourButton15;
    public Button yourButton16;
    public Button yourButton17;

    public Dropdown Dropdown;
    public Dropdown Dropdown1;

    public Text acsel1;
    public Text acsel2;
    public Text acsel3;

    public Text micro1;
    public Text micro2;
    public Text micro3;


    public Camera cam12;

    public GameObject interfObj1;
   
    public GameObject interfObj3;

    public GameObject interfAcs1;
    public GameObject interfAcs2;
    public GameObject interfAcs3;

    public GameObject interfMic1;
    public GameObject interfMic2;

    public GameObject interfRez1;
    public GameObject interfRez2;

    public GameObject statusOff;
    public GameObject statusOn;
    public GameObject statusOff1;
    public GameObject statusOn1;

    public static int KolonkaStatus=0;
    public static int GenStatus = 0;

    void Start()
    {
        Button btn332 = yourButton33.GetComponent<Button>();
        btn332.onClick.AddListener(TaskOnClick33);

        Button btn2 = yourButton2.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2);
     
       
        Button btn6 = yourButton6.GetComponent<Button>();
        btn6.onClick.AddListener(TaskOnClick6);
        Button btn7 = yourButton7.GetComponent<Button>();
        btn7.onClick.AddListener(TaskOnClick7);
        Button btn8 = yourButton8.GetComponent<Button>();
        btn8.onClick.AddListener(TaskOnClick8);

        Button btn9 = yourButton9.GetComponent<Button>();
        btn9.onClick.AddListener(TaskOnClick9);
        Button btn10 = yourButton10.GetComponent<Button>();
        btn10.onClick.AddListener(TaskOnClick10);
        Button btn11 = yourButton11.GetComponent<Button>();
        btn11.onClick.AddListener(TaskOnClick11);

        Button btn12 = yourButton12.GetComponent<Button>();
        btn12.onClick.AddListener(TaskOnClick12);
        Button btn13 = yourButton13.GetComponent<Button>();
        btn13.onClick.AddListener(TaskOnClick13);

        Button btn14 = yourButton14.GetComponent<Button>();
        btn14.onClick.AddListener(TaskOnClick14);
        Button btn15 = yourButton15.GetComponent<Button>();
        btn15.onClick.AddListener(TaskOnClick15);
        Button btn16 = yourButton16.GetComponent<Button>();
        btn16.onClick.AddListener(TaskOnClick16);



        Button btn17 = yourButton17.GetComponent<Button>();
        btn17.onClick.AddListener(TaskOnClick17);

     

        statusOff.SetActive(true);
        statusOn.SetActive(false);

        button6.SetActive(true);
        button7.SetActive(false);

        statusOff1.SetActive(true);
        statusOn1.SetActive(false);

  
    }
   
    public void click()
    {
            int index = Dropdown.value;
            switch (index)
        { 
            case 0:
            micro2.text = "60,4";
            break;
            
            case 1:
            micro2.text = "55,4";
            break;
            
            case 2:
            micro2.text = "58,7";
            break;
            
            case 3:
            micro2.text = "52,2";
            break;
            
            case 4:
            micro2.text = "40,38";
            break;
            
        }
    }
    public void click1()
    {
        int index = Dropdown.value;
        switch (index)
        {
            case 0:
                micro3.text = "25,12";
                break;

            case 1:
                micro3.text = "22,1";
                break;

            case 2:
                micro3.text = "29,3";
                break;

            case 3:
                micro3.text = "23,4";
                break;

            case 4:
                micro3.text = "24,8";
                break;

        }
    }
    public void click2()
    {
        int index = Dropdown.value;
        switch (index)
        {
            case 0:
                micro1.text = "99,52";
                break;

            case 1:
                micro1.text = "100,03";
                break;

            case 2:
                micro1.text = "100,85";
                break;

            case 3:
                micro1.text = "95,56";
                break;

            case 4:
                  micro1.text = "92,8";
                break;

        }
    }
    public void click3()
    {
        int index = Dropdown.value;
        switch (index)
        {
            case 0:
                acsel1.text = "73,300";
                break;

            case 1:
                acsel1.text = "73,080";
                break;

            case 2:
                acsel1.text = "72,510";
                break;

            case 3:
                acsel1.text = "72,700";
                break;

            case 4:
                acsel1.text = "73,630";
                break;

        }
    }
    public void click4()
    {
        int index = Dropdown.value;
        switch (index)
        {
            case 0:
                acsel2.text = "45,740";
                break;

            case 1:
                acsel2.text = "44,2";
                break;

            case 2:
                acsel2.text = "46,8";
                break;

            case 3:
                acsel2.text = "42,01";
                break;

            case 4:
                acsel2.text = "47,99";
                break;

        }
    }
    public void click5()
    {
        int index = Dropdown.value;
        switch (index)
        {
            case 0:
                acsel3.text = "33,33";
                break;

            case 1:
                acsel3.text = "34,69";
                break;

            case 2:
                acsel3.text = "35,61";
                break;

            case 3:
                acsel3.text = "31,69";
                break;

            case 4:
                acsel3.text = "38,85";
                break;

        }
    }
    void Update()
    {
      

        if (KolonkaStatus == 1 && GenStatus == 1)
        {
            if (Dropdown.value == 0)
            {
                micro1.text = "99,52";

            }
            else if (Dropdown.value == 1)
            {
                micro1.text = "100,03";

            }
            else if (Dropdown.value == 2)
            {
                micro1.text = "100,85";

            }
            else if (Dropdown.value == 3)
            {
                micro1.text = "95,56";

            }
            else if (Dropdown.value == 4)
            {
                micro1.text = "92,8";

            }
           
        }
        if (KolonkaStatus == 1 && GenStatus == 1)
        {
            if (Dropdown.value == 0)
            {
                micro2.text = "60,4";

            }
            else if (Dropdown.value == 1)
            {
                micro2.text = "55,4";

            }
            else if (Dropdown.value == 2)
            {
                micro2.text = "58,7";

            }
            else if (Dropdown.value == 3)
            {
                micro2.text = "52,2";

            }
            else if (Dropdown.value == 4)
            {
                micro2.text = "40,38";

            }
        }
        if (KolonkaStatus == 0 && GenStatus == 0)
        {
            if (Dropdown.value == 0)
            {
                micro3.text = "25,12";

            }
            else if (Dropdown.value == 1)
            {
                micro3.text = "22,1";

            }
            else if (Dropdown.value == 2)
            {
                micro3.text = "29,3";

            }
            else if (Dropdown.value == 3)
            {
                micro3.text = "23,4";

            }
            else if (Dropdown.value == 4)
            {
                micro3.text = "24,8";

            }
        }
        if (Dropdown1.value == 1)
        {
            if (KolonkaStatus == 1 && GenStatus == 1)
            {
                if (Dropdown.value == 0)
                {
                    acsel1.text = "73,300";

                }
                else if (Dropdown.value == 1)
                {
                    acsel1.text = "73,080";

                }
                else if (Dropdown.value == 2)
                {
                    acsel1.text = "72,510";

                }
                else if (Dropdown.value == 3)
                {
                    acsel1.text = "72,700";

                }
                else if (Dropdown.value == 4)
                {
                    acsel1.text = "73,630";

                }

            }
            if (KolonkaStatus == 1 && GenStatus == 1)
            {
                if (Dropdown.value == 0)
                {
                    acsel2.text = "45,740";

                }
                else if (Dropdown.value == 1)
                {
                    acsel2.text = "44,2";

                }
                else if (Dropdown.value == 2)
                {
                    acsel2.text = "46,8";

                }
                else if (Dropdown.value == 3)
                {
                    acsel2.text = "42,01";

                }
                else if (Dropdown.value == 4)
                {
                    acsel2.text = "47,99";

                }
                
            }
            if (KolonkaStatus == 0 && GenStatus == 0)
            {
                if (Dropdown.value == 0)
                {
                    acsel3.text = "33,33";

                }
                else if (Dropdown.value == 1)
                {
                    acsel3.text = "34,69";

                }
                else if (Dropdown.value == 2)
                {
                    acsel3.text = "35,61";

                }
                else if (Dropdown.value == 3)
                {
                    acsel3.text = "31,69";

                }
                else if (Dropdown.value == 4)
                {
                    acsel3.text = "38,85";

                }
              
            }
        }
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;

            Ray ray = cam12.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "GenClick")
                {
                    interfObj1.SetActive(true);
                }
                if (Dropdown1.value == 0)
                {
                    if (hit.transform.name == "Micro1Click")
                    {
                        if (KolonkaStatus == 1 && GenStatus == 1)
                        {
                            if (Dropdown.value == 0)
                            {
                                micro1.text = "99,52";

                            }
                            else if (Dropdown.value == 1)
                            {
                                micro1.text = "100,03";

                            }
                            else if (Dropdown.value == 2)
                            {
                                micro1.text = "100,85";

                            }
                            else if (Dropdown.value == 3)
                            {
                                micro1.text = "95,56";

                            }
                            else if (Dropdown.value == 4)
                            {
                                micro1.text = "92,8";

                            }
                            interfMic1.SetActive(false);
                            interfMic2.SetActive(false);
                            interfObj3.SetActive(true);
                        }
                    }
                }
                if (hit.transform.name == "Micro2Click")
                {
                    if (KolonkaStatus == 1 && GenStatus == 1)
                    {
                        if (Dropdown.value == 0)
                        {
                            micro2.text = "60,4";

                        }
                        else if (Dropdown.value == 1)
                        {
                            micro2.text = "55,4";

                        }
                        else if (Dropdown.value == 2)
                        {
                            micro2.text = "58,7";

                        }
                        else if (Dropdown.value == 3)
                        {
                            micro2.text = "52,2";

                        }
                        else if (Dropdown.value == 4)
                        {
                            micro2.text = "40,38";

                        }
                       
                        interfMic2.SetActive(false);
                        interfObj3.SetActive(false);
                        interfMic1.SetActive(true);
                    }
                    if (KolonkaStatus == 0 && GenStatus == 0)
                    {
                        if (Dropdown.value == 0)
                        {
                            micro3.text = "25,12";

                        }
                        else if (Dropdown.value == 1)
                        {
                            micro3.text = "22,1";

                        }
                        else if (Dropdown.value == 2)
                        {
                            micro3.text = "29,3";

                        }
                        else if (Dropdown.value == 3)
                        {
                            micro3.text = "23,4";

                        }
                        else if (Dropdown.value == 4)
                        {
                            micro3.text = "24,8";

                        }
                       
                        interfObj3.SetActive(false);
                        interfMic1.SetActive(false);
                        interfMic2.SetActive(true);
                    }

                }




                if (Dropdown1.value == 1)
                {
                    if (hit.transform.name == "Micro1Click")
                    {
                        if (KolonkaStatus == 1 && GenStatus == 1)
                        {
                            if (Dropdown.value == 0)
                            {
                                acsel1.text = "73,300";

                            }
                            else if (Dropdown.value == 1)
                            {
                                acsel1.text = "73,080";

                            }
                            else if (Dropdown.value == 2)
                            {
                                acsel1.text = "72,510";

                            }
                            else if (Dropdown.value == 3)
                            {
                                acsel1.text = "72,700";

                            }
                            else if (Dropdown.value == 4)
                            {
                                acsel1.text = "73,630";

                            }
                            interfAcs1.SetActive(true);
                            interfAcs2.SetActive(false);
                            interfAcs3.SetActive(false);
                        }
                    }
                }
                if (hit.transform.name == "AcsHitbox")
                {
                    if (KolonkaStatus == 1 && GenStatus == 1)
                    {
                        if (Dropdown.value == 0)
                        {
                            acsel2.text = "45,740";

                        }
                        else if (Dropdown.value == 1)
                        {
                            acsel2.text = "44,2";

                        }
                        else if (Dropdown.value == 2)
                        {
                            acsel2.text = "46,8";

                        }
                        else if (Dropdown.value == 3)
                        {
                            acsel2.text = "42,01";

                        }
                        else if (Dropdown.value == 4)
                        {
                            acsel2.text = "47,99";

                        }
                        interfAcs1.SetActive(false);
                        interfAcs2.SetActive(true);
                        interfAcs3.SetActive(false);
                    }
                    else if (KolonkaStatus == 0 && GenStatus == 0)
                    {
                        if (Dropdown.value == 0)
                        {
                            acsel3.text = "33,33";

                        }
                        else if (Dropdown.value == 1)
                        {
                            acsel3.text = "34,69";

                        }
                        else if (Dropdown.value == 2)
                        {
                            acsel3.text = "35,61";

                        }
                        else if (Dropdown.value == 3)
                        {
                            acsel3.text = "31,69";

                        }
                        else if (Dropdown.value == 4)
                        {
                            acsel3.text = "38,85";

                        }
                        interfAcs1.SetActive(false);
                        interfAcs2.SetActive(false);
                        interfAcs3.SetActive(true);
                    }
                }
                    
                
            }
        }
    }
    void TaskOnClick2()
    {
        interfObj1.SetActive(false);
    }
 
   
    void TaskOnClick6()
    {
        GenStatus++;
        KolonkaStatus++;
        button6.SetActive(false);
        button7.SetActive(true);

        statusOff1.SetActive(false);
        statusOn1.SetActive(true);
        statusOff.SetActive(false);
        statusOn.SetActive(true);
    }
    void TaskOnClick7()
    {
        GenStatus--;
        KolonkaStatus--;
        button6.SetActive(true);
        button7.SetActive(false);

        statusOff1.SetActive(true);
        statusOn1.SetActive(false);
       
        statusOff.SetActive(true);
        statusOn.SetActive(false);
    }
    void TaskOnClick8()
    {
        interfObj3.SetActive(false);
    }
    void TaskOnClick9()
    {
        interfAcs1.SetActive(false);
    }
    void TaskOnClick10()
    {
        interfAcs2.SetActive(false);
    }
    void TaskOnClick11()
    {
        interfAcs3.SetActive(false);
    }
    void TaskOnClick12()
    {
        interfMic1.SetActive(false);
    }
    void TaskOnClick13()
    {
        interfMic2.SetActive(false);
    }
    void TaskOnClick14()
    {
        interfRez1.SetActive(true);
        AlertRez.SetActive(true);
    }
    void TaskOnClick15()
    {
        interfRez2.SetActive(true);
    }
    void TaskOnClick16()
    {
        interfRez2.SetActive(false);
    }
    void TaskOnClick17()
    {
        interfRez1.SetActive(false);
    }
    
    void TaskOnClick33()
    {
        AlertRez.SetActive(false);
    }
}
