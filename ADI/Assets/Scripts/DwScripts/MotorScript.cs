using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorScript : MonoBehaviour
{
    public float power = 0.0f;

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddRelativeForce(0, power, 0);
    }
}