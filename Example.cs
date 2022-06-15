using UnityEngine;
using UnityEngine.EventSystems;

public class Example : MonoBehaviour
{
    public GameObject spawnObj;
    public Camera cam;
    public static int k = 0;
    public static int l = 0;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "ContrMark")
                {
                    Instantiate(spawnObj, hit.point, Quaternion.identity);
                    k++;
                    Debug.Log(k + " Game Object Clicked!");
                }
                if (hit.transform.name == "ColDoor")
                {
                    Instantiate(spawnObj, hit.point, Quaternion.identity);              
                    l++;
                    Debug.Log(l + " Game Object Clicked!");
                }
            }

        }
    }
}