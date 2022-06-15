    using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Building : MonoBehaviour

{

    public Camera camm;//this needs to be set in inspector
    public static int correctPlaceMic1 = 0;




    void Update()
    {
        if (correctPlaceMic1 == 0)
        {
            transform.position = camm.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 2));
        }
        else
        { }
    }

}