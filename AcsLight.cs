using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcsLight : MonoBehaviour
{

    public GameObject acslight;
    void OnMouseEnter()
    {
        acslight.SetActive(true);
    }
    void OnMouseExit()
    {
        acslight.SetActive(false);
    }
}
