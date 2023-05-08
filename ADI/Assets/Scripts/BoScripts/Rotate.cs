using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public bool rotarion = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotarion)
        {
            transform.Rotate(0f, 0f, 40f);
        }
        else
        {
            transform.Rotate(0f, 0f, -40f);
        }
    }
}
