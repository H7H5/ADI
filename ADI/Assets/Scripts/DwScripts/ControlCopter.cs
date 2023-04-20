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
        power = motorScript.power;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("UpArrow key was pressed.");
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

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            Debug.Log("DownArrow key was released.");
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
    }
}
