using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParametersCopter : MonoBehaviour
{

    public float height;
    public string heightString;

    private void Start()
    {
        height = transform.position.y;
    }

    private void FixedUpdate()
    {
        height = transform.position.y;
        heightString = height.ToString("F2");
    }
}
