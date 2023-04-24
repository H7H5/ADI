using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCopter : MonoBehaviour
{
    public float power = 0.0f;

    private float powerStep = 0.1f;

    private float powerMin = 0f;
    private float powerMax = 25f;

    public MotorScript motorScript;
    public MotorScript motorScript1;
    public MotorScript motorScript2;
    public MotorScript motorScript3;

    private void Start()
    {
        //power = motorScript.power;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            power += powerStep;
            if(power > powerMax)
            {
                power = powerMax;
            }
            motorScript.power = power;
            motorScript1.power = power;
            motorScript2.power = power;
            motorScript3.power = power;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            power -= powerStep;
            if(power < powerMin)
            {
                power = powerMin;
            }
            motorScript.power = power;
            motorScript1.power = power;
            motorScript2.power = power;
            motorScript3.power = power;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            motorScript.power += powerStep;
            motorScript1.power += powerStep;

            motorScript2.power -= powerStep;
            motorScript3.power -= powerStep;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            motorScript.power -= powerStep;
            motorScript1.power -= powerStep;

            motorScript2.power += powerStep;
            motorScript3.power += powerStep;
        }
    }
}
