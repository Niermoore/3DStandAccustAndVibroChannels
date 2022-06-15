using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build5 : MonoBehaviour
{
    public Camera camm;//this needs to be set in inspector
    public static int correctPlaceMetr = 0;


    void Update()
    {
        if (correctPlaceMetr == 0)
        {
            transform.position = camm.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 2));
        }
        else
        { }
    }

}

