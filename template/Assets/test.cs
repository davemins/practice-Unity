using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    int count = 0;

    void Start () {
        if (Input.GetKey (KeyCode.Alpha2)) {
            Debug.Log ("2(@) is pressed!!");
        }
    }
    


    void Update () {

        if (Input.GetKeyUp (KeyCode.U)) {
            Debug.Log ("U " + Input.mousePosition);
        }

        if (Input.GetKeyDown (KeyCode.Space)) {
            
            count += 1;
            Debug.Log ("Space " + count);
        }

        if (Input.GetMouseButtonUp (1))
        {
            count -= 1;
            Debug.Log ("Mouse " + count);
        }
    }
}
