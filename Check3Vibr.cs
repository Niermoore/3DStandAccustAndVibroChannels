using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Globalization;
using UnityEngine;
using System.IO;

public class CheckVibr : MonoBehaviour
{
    public Button yourButton;
    public Button yourButton1;


    public Button yourButton111;

    public GameObject alert111;

    public GameObject Button1;
    public GameObject Button11;
    public GameObject SucText1;
    public GameObject SucText2;

    public InputField VTci250;
    public InputField VTci500;
    public InputField VTci1000;
    public InputField VTci2000;
    public InputField VTci4000;

    public InputField VCSHi250;
    public InputField VCSHi500;
    public InputField VCSHi1000;
    public InputField VCSHi2000;
    public InputField VCSHi4000;

    public InputField VSHi250;
    public InputField VSHi500;
    public InputField VSHi1000;
    public InputField VSHi2000;
    public InputField VSHi4000;

    public InputField VCi250;
    public InputField VCi500;
    public InputField VCi1000;
    public InputField VCi2000;
    public InputField VCi4000;
    public float VCi250i;
    public float VCi500i;
    public float VCi1000i;
    public float VCi2000i;
    public float VCi4000i;

    public InputField VHi250;
    public InputField VHi500;
    public InputField VHi1000;
    public InputField VHi2000;
    public InputField VHi4000;
    public int VHi250i;
    public int VHi500i;
    public int VHi1000i;
    public int VHi2000i;
    public int VHi4000i;

    public InputField Vi250;
    public InputField Vi500;
    public InputField Vi1000;
    public InputField Vi2000;
    public InputField Vi4000;
    public float Vi250i;
    public float Vi500i;
    public float Vi1000i;
    public float Vi2000i;
    public float Vi4000i;

    public InputField VCpi250;
    public InputField VCpi500;
    public InputField VCpi1000;
    public InputField VCpi2000;
    public InputField VCpi4000;
    public float VCpi250i;
    public float VCpi500i;
    public float VCpi1000i;
    public float VCpi2000i;
    public float VCpi4000i;

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

        filename = Application.dataPath + "/test1.csv";

    }

    void TaskOnClick()
    {
        Status = 0;
        if (VTci250.text == "73.3")
        { Debug.Log("Хорошо"); VTci250.image.color = Color.white; }
        else { Status--;
            VTci250.image.color = Color.red;
        }
        if (VTci500.text == "73.08")
        { Debug.Log("Хорошо"); VTci500.image.color = Color.white; }
        else { Status--;
            VTci500.image.color = Color.red;
        }
        if (VTci1000.text == "72.51")
        { Debug.Log("Хорошо"); VTci1000.image.color = Color.white; }
        else { Status--;
            VTci1000.image.color = Color.red;
        }
        if (VTci2000.text == "72.70")
        { Debug.Log("Хорошо"); VTci2000.image.color = Color.white; }
        else { Status--;
            VTci2000.image.color = Color.red;
        }
        if (VTci4000.text == "73.63")
        { Debug.Log("Хорошо"); VTci4000.image.color = Color.white; }
        else { Status--;
            VTci4000.image.color = Color.red;
        }

        if (VCSHi250.text == "45.74")
        { Debug.Log("Хорошо"); VCSHi250.image.color = Color.white; }
        else { Status--; VCSHi250.image.color = Color.red; }
        if (VCSHi500.text == "44.2")
        { Debug.Log("Хорошо"); VCSHi500.image.color = Color.white; }
        else { Status--; VCSHi500.image.color = Color.red; }
        if (VCSHi1000.text == "46.8")
        { Debug.Log("Хорошо"); VCSHi1000.image.color = Color.white; }
        else { Status--; VCSHi1000.image.color = Color.red; }
        if (VCSHi2000.text == "42.01")
        { Debug.Log("Хорошо"); VCSHi2000.image.color = Color.white; }
        else { Status--; VCSHi2000.image.color = Color.red; }
        if (VCSHi4000.text == "47.99")
        { Debug.Log("Хорошо"); VCSHi4000.image.color = Color.white; }
        else { Status--; VCSHi4000.image.color = Color.red; }

        if (VSHi250.text == "33.33")
        { Debug.Log("Хорошо"); VSHi250.image.color = Color.white; }
        else { Status--; VSHi250.image.color = Color.red; }
        if (VSHi500.text == "34.69")
        { Debug.Log("Хорошо"); VSHi500.image.color = Color.white; }
        else { Status--; VSHi500.image.color = Color.red; }
        if (VSHi1000.text == "35.61")
        { Debug.Log("Хорошо"); VSHi1000.image.color = Color.white; }
        else { Status--; VSHi1000.image.color = Color.red; }
        if (VSHi2000.text == "31.69")
        { Debug.Log("Хорошо"); VSHi2000.image.color = Color.white; }
        else { Status--; VSHi2000.image.color = Color.red; }
        if (VSHi4000.text == "38.85")
        { Debug.Log("Хорошо"); VSHi4000.image.color = Color.white; }
        else { Status--; VSHi4000.image.color = Color.red; }

        if (Status == 0)
        {
            Debug.Log(Status + " Готово");
            Button1.SetActive(false);
            SucText2.SetActive(true);
        }
        else
        {
            Debug.Log(Status + " Не готово");
            alert111.SetActive(true);
        }
    }
    void TaskOnClick1()
    {
        StatusForEndRez = 0;

        VCi250i = float.Parse(VCi250.text, CultureInfo.InvariantCulture);
        if (VCi250i >= 42.2 && VCi250i <= 42.7)
        { Debug.Log("Хорошо"); VCi250.image.color = Color.white; }
        else { StatusForEndRez--; VCi250.image.color = Color.red; }
        VCi500i = float.Parse(VCi500.text, CultureInfo.InvariantCulture);
        if (VCi500i >= 43.4 && VCi500i <= 43.9)
        { Debug.Log("Хорошо"); VCi500.image.color = Color.white; }
        else { StatusForEndRez--; VCi500.image.color = Color.red; }
        VCi1000i = float.Parse(VCi1000.text, CultureInfo.InvariantCulture);
        if (VCi1000i >= 46.2 && VCi1000i <= 46.7)
        { Debug.Log("Хорошо"); VCi1000.image.color = Color.white; }
        else { StatusForEndRez--; VCi1000.image.color = Color.red; }
        VCi2000i = float.Parse(VCi2000.text, CultureInfo.InvariantCulture);
        if (VCi2000i >= 41.2 && VCi2000i <= 41.8)
        { Debug.Log("Хорошо"); VCi2000.image.color = Color.white; }
        else { StatusForEndRez--; VCi2000.image.color = Color.red; }
        VCi4000i = float.Parse(VCi4000.text, CultureInfo.InvariantCulture);
        if (VCi4000i >= 47.1 && VCi4000i <= 47.7)
        { Debug.Log("Хорошо"); VCi4000.image.color = Color.white; }
        else { StatusForEndRez--; VCi4000.image.color = Color.red; }

        VHi250i = int.Parse(VHi250.text, CultureInfo.InvariantCulture);
        if (VHi250i == 66)
        { Debug.Log("Хорошо"); VHi250.image.color = Color.white; }
        else { StatusForEndRez--; VHi250.image.color = Color.red; }
        VHi500i = int.Parse(VHi500.text, CultureInfo.InvariantCulture);
        if (VHi500i == 66)
        { Debug.Log("Хорошо"); VHi500.image.color = Color.white; }
        else { StatusForEndRez--; VHi500.image.color = Color.red; }
        VHi1000i = int.Parse(VHi1000.text, CultureInfo.InvariantCulture);
        if (VHi1000i == 61)
        { Debug.Log("Хорошо"); VHi1000.image.color = Color.white; }
        else { StatusForEndRez--; VHi1000.image.color = Color.red; }
        VHi2000i = int.Parse(VHi2000.text, CultureInfo.InvariantCulture);
        if (VHi2000i == 56)
        { Debug.Log("Хорошо"); VHi2000.image.color = Color.white; }
        else { StatusForEndRez--; VHi2000.image.color = Color.red; }
        VHi4000i = int.Parse(VHi4000.text, CultureInfo.InvariantCulture);
        if (VHi4000i == 53)
        { Debug.Log("Хорошо"); VHi4000.image.color = Color.white; }
        else { StatusForEndRez--; VHi4000.image.color = Color.red; }

        Vi250i = float.Parse(Vi250.text, CultureInfo.InvariantCulture);
        if (Vi250i >= 7.1 && Vi250i <= 7.6)
        { Debug.Log("Хорошо"); Vi250.image.color = Color.white; }
        else { StatusForEndRez--; Vi250.image.color = Color.red; }
        Vi500i = float.Parse(Vi500.text, CultureInfo.InvariantCulture);
        if (Vi500i >= 7.0 && Vi500i <= 7.3)
        { Debug.Log("Хорошо"); Vi500.image.color = Color.white; }
        else { StatusForEndRez--; Vi500.image.color = Color.red; }
        Vi1000i = float.Parse(Vi1000.text, CultureInfo.InvariantCulture);
        if (Vi1000i >= 11.1 && Vi1000i <= 11.8)
        { Debug.Log("Хорошо"); Vi1000.image.color = Color.white; }
        else { StatusForEndRez--; Vi1000.image.color = Color.red; }
        Vi2000i = float.Parse(Vi2000.text, CultureInfo.InvariantCulture);
        if (Vi2000i >= 16.3 && Vi2000i <= 16.9)
        { Debug.Log("Хорошо"); Vi2000.image.color = Color.white; }
        else { StatusForEndRez--; Vi2000.image.color = Color.red; }
        Vi4000i = float.Parse(Vi4000.text, CultureInfo.InvariantCulture);
        if (Vi4000i >= 20.3 && Vi4000i <= 20.8)
        { Debug.Log("Хорошо"); Vi4000.image.color = Color.white; }
        else { StatusForEndRez--; Vi4000.image.color = Color.red; }

        VCpi250i = float.Parse(VCpi250.text, CultureInfo.InvariantCulture);
        if (VCpi250i >= 38.0 && VCpi250i <= 38.5)
        { Debug.Log("Хорошо"); VCpi250.image.color = Color.white; }
        else { StatusForEndRez--; VCpi250.image.color = Color.red; }
        VCpi500i = float.Parse(VCpi500.text, CultureInfo.InvariantCulture);
        if (VCpi500i >= 36.3 && VCpi500i <= 36.9)
        { Debug.Log("Хорошо"); VCpi500.image.color = Color.white; }
        else { StatusForEndRez--; VCpi500.image.color = Color.red; }
        VCpi1000i = float.Parse(VCpi1000.text, CultureInfo.InvariantCulture);
        if (VCpi1000i >= 34.4 && VCpi1000i <= 35.1)
        { Debug.Log("Хорошо"); VCpi1000.image.color = Color.white; }
        else { StatusForEndRez--; VCpi1000.image.color = Color.red; }
        VCpi2000i = float.Parse(VCpi2000.text, CultureInfo.InvariantCulture);
        if (VCpi2000i >= 24.4 && VCpi2000i <= 25.0)
        { Debug.Log("Хорошо"); VCpi2000.image.color = Color.white; }
        else { StatusForEndRez--; VCpi2000.image.color = Color.red; }
        VCpi4000i = float.Parse(VCpi4000.text, CultureInfo.InvariantCulture);
        if (VCpi4000i >= 26.4 && VCpi4000i <= 27.0)
        { Debug.Log("Хорошо"); VCpi4000.image.color = Color.white; }
        else { StatusForEndRez--; VCpi4000.image.color = Color.red; }

        Ei250i = float.Parse(Ei250.text, CultureInfo.InvariantCulture);
        if (Ei250i >= 4.5 && Ei250i <= 5.0)
        { Debug.Log("Хорошо"); Ei250.image.color = Color.white; }
        else { StatusForEndRez--; Ei250.image.color = Color.red; }
        Ei500i = float.Parse(Ei500.text, CultureInfo.InvariantCulture);
        if (Ei500i >= 1.5 && Ei500i <= 2.2)
        { Debug.Log("Хорошо"); Ei500.image.color = Color.white; }
        else { StatusForEndRez--; Ei500.image.color = Color.red; }
        Ei1000i = float.Parse(Ei1000.text, CultureInfo.InvariantCulture);
        if (Ei1000i <= -0.4 && Ei1000i >= -0.9)
        { Debug.Log("Хорошо"); Ei1000.image.color = Color.white; }
        else { StatusForEndRez--; Ei1000.image.color = Color.red; }
        Ei2000i = float.Parse(Ei2000.text, CultureInfo.InvariantCulture);
        if (Ei2000i <= -6.5 && Ei2000i >= -7.0)
        { Debug.Log("Хорошо"); Ei2000.image.color = Color.white; }
        else { StatusForEndRez--; Ei2000.image.color = Color.red; }
        Ei4000i = float.Parse(Ei4000.text, CultureInfo.InvariantCulture);
        if (Ei4000i <= -11.8 && Ei4000i >= -12.4)
        { Debug.Log("Хорошо"); Ei4000.image.color = Color.white; }
        else { StatusForEndRez--; Ei4000.image.color = Color.red; }

        Wci = float.Parse(Wc.text, CultureInfo.InvariantCulture);
        if (Wci <= 0.74 && Wci >= 0.68)
        { Debug.Log("Хорошо"); Wc.image.color = Color.white; }
        else { StatusForEndRez--; Wc.image.color = Color.red; }

        Wpri = float.Parse(Wpr.text, CultureInfo.InvariantCulture);
        if (Wpri > 0.29 && Wpri < 0.31)
        { Debug.Log("Хорошо"); Wpr.image.color = Color.white; }
        else { StatusForEndRez--; Wpr.image.color = Color.red; }

      

        if (StatusForEndRez == 0)
        {
            Debug.Log(StatusForEndRez + " Готово");
            Button11.SetActive(false);
            SucText1.SetActive(true);
   

            WriteCSV();
        }
        else
        {
            Debug.Log(StatusForEndRez + " Не готово");
            alert111.SetActive(true);
        
        }
    }

    void TaskOnClick111()
    {
        alert111.SetActive(false);
    }

    public void WriteCSV()
    {
        float i1 = float.Parse(VSHi250.text, CultureInfo.InvariantCulture);
        float i2 = float.Parse(VSHi500.text, CultureInfo.InvariantCulture);
        float i3 = float.Parse(VSHi1000.text, CultureInfo.InvariantCulture);
        float i4 = float.Parse(VSHi2000.text, CultureInfo.InvariantCulture);
        float i5 = float.Parse(VSHi4000.text, CultureInfo.InvariantCulture);

        float i6 = float.Parse(VCpi2000.text, CultureInfo.InvariantCulture);
        float i7 = float.Parse(Ei250.text, CultureInfo.InvariantCulture);
        TextWriter tw = new StreamWriter(filename, false);
        tw.WriteLine("Octavs; 250; 500; 1000; 2000; 4000");
        tw.Close();

        tw = new StreamWriter(filename, true);
        tw.WriteLine("VTci" + ";" + VTci250.text + ";" + VTci500.text + ";" + VTci1000.text + ";" + VTci2000.text + ";" + VTci4000.text);



        tw.WriteLine("Vc+shi" + ";" + VCSHi250.text + ";" + VCSHi500.text + ";" + VCSHi1000.text + ";" + VCSHi2000.text + ";" + VCSHi4000.text);



        tw.WriteLine("Vshi" + ";" + i1 + ";" + i2 + ";" + i3 + ";" + i4 + ";" + i5);



        tw.WriteLine("VCi" + ";" + VCi250.text + ";" + VCi500.text + ";" + VCi1000.text + ";" + VCi2000.text + ";" + VCi4000.text);



        tw.WriteLine("VHi" + ";" + VHi250.text + ";" + VHi500.text + ";" + VHi1000.text + ";" + VHi2000.text + ";" + VHi4000.text);



        tw.WriteLine("DeltaVi" + ";" + Vi250.text + ";" + Vi500.text + ";" + Vi1000.text + ";" + Vi2000.text + ";" + Vi4000.text);



        tw.WriteLine("VC.priv.i" + ";" + VCpi250.text + ";" + VCpi500.text + ";" + VCpi1000.text + ";" + i6 + ";" + VCpi4000.text);



        tw.WriteLine("Ei" + ";" + i7 + ";" + Ei500.text + ";" + Ei1000.text + ";" + Ei2000.text + ";" + Ei4000.text);



        tw.WriteLine("Wc" + ";" + Wc.text);



        tw.WriteLine("W pr. " + ";" + Wpr.text);



     
        tw.Close();

    }
}
