using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Globalization;
using UnityEngine;
using System.IO;

public class CheckAcust1 : MonoBehaviour
{
    public Button yourButton;
    public Button yourButton1;

  
    public Button yourButton111;
  
    public GameObject alert111;

    public GameObject Button1;
    public GameObject Button11;
    public GameObject SucText1;
    public GameObject SucText2;

    public InputField LTci250;
    public InputField LTci500;
    public InputField LTci1000;
    public InputField LTci2000;
    public InputField LTci4000;

    public InputField LCSHi250;
    public InputField LCSHi500;
    public InputField LCSHi1000;
    public InputField LCSHi2000;
    public InputField LCSHi4000;

    public InputField LSHi250;
    public InputField LSHi500;
    public InputField LSHi1000;
    public InputField LSHi2000;
    public InputField LSHi4000;

    public InputField LCi250;
    public InputField LCi500;
    public InputField LCi1000;
    public InputField LCi2000;
    public InputField LCi4000;
    public float LCi250i;
    public float LCi500i;
    public float LCi1000i;
    public float LCi2000i;
    public float LCi4000i;

    public InputField LHi250;
    public InputField LHi500;
    public InputField LHi1000;
    public InputField LHi2000;
    public InputField LHi4000;
    public int LHi250i;
    public int LHi500i;
    public int LHi1000i;
    public int LHi2000i;
    public int LHi4000i;

    public InputField Li250;
    public InputField Li500;
    public InputField Li1000;
    public InputField Li2000;
    public InputField Li4000;
    public float Li250i;
    public float Li500i;
    public float Li1000i;
    public float Li2000i;
    public float Li4000i;

    public InputField LCpi250;
    public InputField LCpi500;
    public InputField LCpi1000;
    public InputField LCpi2000;
    public InputField LCpi4000;
    public float LCpi250i;
    public float LCpi500i;
    public float LCpi1000i;
    public float LCpi2000i;
    public float LCpi4000i;

    public InputField Ei250;
    public InputField Ei500;
    public InputField Ei1000;
    public InputField Ei2000;
    public InputField Ei4000;
    public float Ei250i;
    public float Ei500i;
    public float Ei1000i;
    public float Ei2000i;
    public float Ei4000i;

    public InputField Wc;
    public float Wci;

    public InputField Wpr;
    public float Wpri;

    public InputField Wnepr;
    public float Wnepri;

    public int Status;
    public int StatusForEndRez;

    string filename = "";
    public static int CheckAcust = 0;


    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        Button btn1 = yourButton1.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick1);

    

        Button btn111 = yourButton111.GetComponent<Button>();
        btn111.onClick.AddListener(TaskOnClick111);

        filename = Application.dataPath + "/test.csv";

    }

    void TaskOnClick()
    {
        Status = 0;
        if (LTci250.text == "99.52")
        { Debug.Log("Хорошо");
            LTci250.image.color = Color.white;
        }
        else { Status--;
            LTci250.image.color = Color.red;
        }
        if (LTci500.text == "100.03")
        { Debug.Log("Хорошо");
            LTci500.image.color = Color.white;
        }
        else { Status--;
            LTci500.image.color = Color.red;
        }
        if (LTci1000.text == "100.85")
        { Debug.Log("Хорошо");
            LTci1000.image.color = Color.white;
        }
        else { Status--;
            LTci1000.image.color = Color.red;
        }
        if (LTci2000.text == "95.56")
        { Debug.Log("Хорошо");
            LTci2000.image.color = Color.white;
        }
        else { Status--;
            LTci2000.image.color = Color.red;
        }
        if (LTci4000.text == "92.8")
        { Debug.Log("Хорошо");
            LTci4000.image.color = Color.white;
        }
        else { Status--;
            LTci4000.image.color = Color.red;
        }

        if (LCSHi250.text == "60.4")
        { Debug.Log("Хорошо");
            LCSHi250.image.color = Color.white;
        }
        else { Status--;
            LCSHi250.image.color = Color.red;
        }
        if (LCSHi500.text == "55.4")
        { Debug.Log("Хорошо");
            LCSHi500.image.color = Color.white;
        }
        else { Status--;
            LCSHi500.image.color = Color.red;
        }
        if (LCSHi1000.text == "58.7")
        { Debug.Log("Хорошо");
            LCSHi1000.image.color = Color.white;
        }
        else { Status--;
            LCSHi1000.image.color = Color.red;
        }
        if (LCSHi2000.text == "52.2")
        { Debug.Log("Хорошо");
            LCSHi2000.image.color = Color.white;
        }
        else { Status--;
            LCSHi2000.image.color = Color.red;
        }
        if (LCSHi4000.text == "40.38")
        { Debug.Log("Хорошо");
            LCSHi4000.image.color = Color.white;
        }
        else { Status--;
            LCSHi4000.image.color = Color.red;
        }

        if (LSHi250.text == "25.12")
        { Debug.Log("Хорошо");
            LSHi250.image.color = Color.white;
        }
        else { Status--;
            LSHi250.image.color = Color.red;
        }
        if (LSHi500.text == "22.1")
        { Debug.Log("Хорошо");
            LSHi500.image.color = Color.white;
        }
        else { Status--;
            LSHi500.image.color = Color.red;
        }
        if (LSHi1000.text == "29.3")
        { Debug.Log("Хорошо");
            LSHi1000.image.color = Color.white;
        }
        else { Status--;
            LSHi1000.image.color = Color.red;
        }
        if (LSHi2000.text == "23.4")
        { Debug.Log("Хорошо");
            LSHi2000.image.color = Color.white;
        }
        else { Status--;
            LSHi2000.image.color = Color.red;
        }
        if (LSHi4000.text == "24.8")
        { Debug.Log("Хорошо");
            LSHi4000.image.color = Color.white;
        }
        else { Status--;
            LSHi4000.image.color = Color.red;
        }

        if (Status == 0)
        {
            Debug.Log(Status + " Готово");
            Button1.SetActive(false);
            SucText1.SetActive(true);
        }
        else { Debug.Log(Status + " Не готово");
            alert111.SetActive(true);
        }
    }
    void TaskOnClick1()
    {
        StatusForEndRez = 0;

        LCi250i = float.Parse(LCi250.text, CultureInfo.InvariantCulture);
        if (LCi250i >= 60.2 && LCi250i <= 60.6)
        { Debug.Log("Хорошо"); LCi250.image.color = Color.white; }
        else { StatusForEndRez--;
            LCi250.image.color = Color.red;
        }
        LCi500i = float.Parse(LCi500.text, CultureInfo.InvariantCulture);
        if (LCi500i >= 55.1 && LCi500i <= 55.7)
        { Debug.Log("Хорошо"); LCi500.image.color = Color.white;
           
        }
        else { StatusForEndRez--; LCi500.image.color = Color.red; }
        LCi1000i = float.Parse(LCi1000.text, CultureInfo.InvariantCulture);
        if (LCi1000i >= 58.3 && LCi1000i <= 59.0)
        { Debug.Log("Хорошо"); LCi1000.image.color = Color.white; }
        else { StatusForEndRez--;
            LCi1000.image.color = Color.red;
        }
        LCi2000i = float.Parse(LCi2000.text, CultureInfo.InvariantCulture);
        if (LCi2000i >= 51.7 && LCi2000i <= 52.6)
        { Debug.Log("Хорошо"); LCi2000.image.color = Color.white; }
        else { StatusForEndRez--;
            LCi2000.image.color = Color.red;
        }
        LCi4000i = float.Parse(LCi4000.text, CultureInfo.InvariantCulture);
        if (LCi4000i >= 40.1 && LCi4000i <= 40.6)
        { Debug.Log("Хорошо"); LCi4000.image.color = Color.white; }
        else { StatusForEndRez--;
            LCi4000.image.color = Color.red;
        }

        LHi250i = int.Parse(LHi250.text, CultureInfo.InvariantCulture);
        if (LHi250i == 66)
        { Debug.Log("Хорошо"); LHi250.image.color = Color.white; }
        else { StatusForEndRez--; LHi250.image.color = Color.red; }
        LHi500i = int.Parse(LHi500.text, CultureInfo.InvariantCulture);
        if (LHi500i == 66)
        { Debug.Log("Хорошо"); LHi500.image.color = Color.white; }
        else { StatusForEndRez--; LHi500.image.color = Color.red; }
        LHi1000i = int.Parse(LHi1000.text, CultureInfo.InvariantCulture);
        if (LHi1000i == 61)
        { Debug.Log("Хорошо"); LHi1000.image.color = Color.white; }
        else { StatusForEndRez--; LHi1000.image.color = Color.red; }
        LHi2000i = int.Parse(LHi2000.text, CultureInfo.InvariantCulture);
        if (LHi2000i == 56)
        { Debug.Log("Хорошо"); LHi2000.image.color = Color.white; }
        else { StatusForEndRez--; LHi2000.image.color = Color.red; }
        LHi4000i = int.Parse(LHi4000.text, CultureInfo.InvariantCulture);
        if (LHi4000i == 53)
        { Debug.Log("Хорошо"); LHi4000.image.color = Color.white; }
        else { StatusForEndRez--; LHi4000.image.color = Color.red; }

        Li250i = float.Parse(Li250.text, CultureInfo.InvariantCulture);
        if (Li250i >= 33.2 && Li250i <= 33.6)
        { Debug.Log("Хорошо"); Li250.image.color = Color.white; }
        else { StatusForEndRez--; Li250.image.color = Color.red; }
        Li500i = float.Parse(Li500.text, CultureInfo.InvariantCulture);
        if (Li500i >= 33.8 && Li500i <= 34.3)
        { Debug.Log("Хорошо"); Li500.image.color = Color.white; }
        else { StatusForEndRez--; Li500.image.color = Color.red; }
        Li1000i = float.Parse(Li1000.text, CultureInfo.InvariantCulture);
        if (Li1000i >= 39.3 && Li1000i <= 40.2)
        { Debug.Log("Хорошо"); Li1000.image.color = Color.white; }
        else { StatusForEndRez--; Li1000.image.color = Color.red; }
        Li2000i = float.Parse(Li2000.text, CultureInfo.InvariantCulture);
        if (Li2000i >= 39.1 && Li2000i <= 39.9)
        { Debug.Log("Хорошо"); Li2000.image.color = Color.white; }
        else { StatusForEndRez--; Li2000.image.color = Color.red; }
        Li4000i = float.Parse(Li4000.text, CultureInfo.InvariantCulture);
        if (Li4000i >= 39.1 && Li4000i <= 40.2)
        { Debug.Log("Хорошо"); Li4000.image.color = Color.white; }
        else { StatusForEndRez--; Li4000.image.color = Color.red; }

        LCpi250i = float.Parse(LCpi250.text, CultureInfo.InvariantCulture);
        if (LCpi250i >= 26.5 && LCpi250i <= 27.3)
        { Debug.Log("Хорошо"); LCpi250.image.color = Color.white; }
        else { StatusForEndRez--; LCpi250.image.color = Color.red; }
        LCpi500i = float.Parse(LCpi500.text, CultureInfo.InvariantCulture);
        if (LCpi500i >= 21.1 && LCpi500i <= 21.9)
        { Debug.Log("Хорошо"); LCpi500.image.color = Color.white; }
        else { StatusForEndRez--; LCpi500.image.color = Color.red; }
        LCpi1000i = float.Parse(LCpi1000.text, CultureInfo.InvariantCulture);
        if (LCpi1000i >= 18.1 && LCpi1000i <= 18.8)
        { Debug.Log("Хорошо"); LCpi1000.image.color = Color.white; }
        else { StatusForEndRez--; LCpi1000.image.color = Color.red; }
        LCpi2000i = float.Parse(LCpi2000.text, CultureInfo.InvariantCulture);
        if (LCpi2000i >= 12.1 && LCpi2000i <= 12.9)
        { Debug.Log("Хорошо"); LCpi2000.image.color = Color.white; }
        else { StatusForEndRez--; LCpi2000.image.color = Color.red; }
        LCpi4000i = float.Parse(LCpi4000.text, CultureInfo.InvariantCulture);
        if (LCpi4000i >= 0.1 && LCpi4000i <= 0.8)
        { Debug.Log("Хорошо"); LCpi4000.image.color = Color.white; }
        else { StatusForEndRez--; LCpi4000.image.color = Color.red; }

        Ei250i = float.Parse(Ei250.text, CultureInfo.InvariantCulture);
        if (Ei250i >= 1.4 && Ei250i <= 1.9)
        { Debug.Log("Хорошо"); Ei250.image.color = Color.white; }
        else { StatusForEndRez--; Ei250.image.color = Color.red; }
        Ei500i = float.Parse(Ei500.text, CultureInfo.InvariantCulture);
        if (Ei500i <= -0.5 && Ei500i >= -1.1)
        { Debug.Log("Хорошо"); Ei500.image.color = Color.white; }
        else { StatusForEndRez--; Ei500.image.color = Color.red; }
        Ei1000i = float.Parse(Ei1000.text, CultureInfo.InvariantCulture);
        if (Ei1000i <= -10.1 && Ei1000i >= -10.5)
        { Debug.Log("Хорошо"); Ei1000.image.color = Color.white; }
        else { StatusForEndRez--; Ei1000.image.color = Color.red; }
        Ei2000i = float.Parse(Ei2000.text, CultureInfo.InvariantCulture);
        if (Ei2000i <= -10.4 && Ei2000i >= -11.1)
        { Debug.Log("Хорошо"); Ei2000.image.color = Color.white; }
        else { StatusForEndRez--; Ei2000.image.color = Color.red; }
        Ei4000i = float.Parse(Ei4000.text, CultureInfo.InvariantCulture);
        if (Ei4000i <= -24.0 && Ei4000i >= -24.7)
        { Debug.Log("Хорошо"); Ei4000.image.color = Color.white; }
        else { StatusForEndRez--; Ei4000.image.color = Color.red; }

        Wci = float.Parse(Wc.text, CultureInfo.InvariantCulture);
        if (Wci <= 0.37 && Wci >= 0.31)
        { Debug.Log("Хорошо"); Wc.image.color = Color.white; }
        else { StatusForEndRez--; Wc.image.color = Color.red; }

        Wpri = float.Parse(Wpr.text, CultureInfo.InvariantCulture);
        if (Wpri > 0.29 && Wpri < 0.31)
        { Debug.Log("Хорошо"); Wpr.image.color = Color.white; }
        else { StatusForEndRez--; Wpr.image.color = Color.red; }

        Wnepri = float.Parse(Wnepr.text, CultureInfo.InvariantCulture);
        if (Wnepri == 0.5)
        { Debug.Log("Хорошо"); Wnepr.image.color = Color.white; }
        else { StatusForEndRez--; Wnepr.image.color = Color.red; }

        if (StatusForEndRez == 0)
        {
            Debug.Log(StatusForEndRez + " Готово");
            Button11.SetActive(false);
            SucText2.SetActive(true);
            CheckAcust++;
         
            WriteCSV();
        }
        else { Debug.Log(StatusForEndRez + " Не готово");
            alert111.SetActive(true);
            CheckAcust++;
        }
    }
  
    void TaskOnClick111()
    {
        alert111.SetActive(false);
    }

    public void WriteCSV()
    {
        float i1 = float.Parse(LSHi250.text, CultureInfo.InvariantCulture);
        float i2 = float.Parse(LSHi500.text, CultureInfo.InvariantCulture);
        float i3 = float.Parse(LSHi1000.text, CultureInfo.InvariantCulture);
        float i4 = float.Parse(LSHi2000.text, CultureInfo.InvariantCulture);
        float i5 = float.Parse(LSHi4000.text, CultureInfo.InvariantCulture);

        float i6 = float.Parse(LCpi2000.text, CultureInfo.InvariantCulture);
        float i7 = float.Parse(Ei250.text, CultureInfo.InvariantCulture);
        TextWriter tw = new StreamWriter(filename, false);
        tw.WriteLine("Octavs; 250; 500; 1000; 2000; 4000");
        tw.Close();

        tw = new StreamWriter(filename, true);
        tw.WriteLine("LTci" + ";" + LTci250.text + ";" + LTci500.text + ";" + LTci1000.text + ";" + LTci2000.text + ";" + LTci4000.text);
   

   
        tw.WriteLine("Lc+shi" + ";" + LCSHi250.text + ";" + LCSHi500.text + ";" + LCSHi1000.text + ";" + LCSHi2000.text + ";" + LCSHi4000.text);
     

      
        tw.WriteLine("Lshi" + ";" + i1 + ";" + i2 + ";" + i3 + ";" + i4 + ";" + i5);
 

      
        tw.WriteLine("LCi" + ";" + LCi250.text + ";" + LCi500.text + ";" + LCi1000.text + ";" + LCi2000.text + ";" + LCi4000.text);
      

   
        tw.WriteLine("LHi" + ";" + LHi250.text + ";" + LHi500.text + ";" + LHi1000.text + ";" + LHi2000.text + ";" + LHi4000.text);
    

   
        tw.WriteLine("DeltaLi" + ";" + Li250.text + ";" + Li500.text + ";" + Li1000.text + ";" + Li2000.text + ";" + Li4000.text);
  

     
        tw.WriteLine("LC.priv.i" + ";" + LCpi250.text + ";" + LCpi500.text + ";" + LCpi1000.text + ";" + i6 + ";" + LCpi4000.text);
      

      
        tw.WriteLine("Ei" + ";" + i7 + ";" + Ei500.text + ";" + Ei1000.text + ";" + Ei2000.text + ";" + Ei4000.text);
     

      
        tw.WriteLine("Wc" + ";" + Wc.text);


     
        tw.WriteLine("W pr. " + ";" + Wpr.text);


   
        tw.WriteLine("W nepr.pr" + ";" + Wnepr.text);
        tw.Close();

    }
}
