
using UnityEngine;


public class Title : MonoBehaviour
{
    private void Update()
    {
    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        print(mousePosition);
       // print("A"+Input.mousePosition);
    }

}
