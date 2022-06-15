using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Micro1Light : MonoBehaviour
{

    public GameObject microlight;
    void OnMouseEnter()
    {
        microlight.SetActive(true);
    }
    void OnMouseExit()
    {
        microlight.SetActive(false);
    }
}
