using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorLight : MonoBehaviour
{

    public GameObject genlight;


    void OnMouseEnter()
    {
        genlight.SetActive(true);
     
    }
    void OnMouseExit()
    {
        genlight.SetActive(false);
     
    }
}
