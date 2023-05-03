using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gorizont : MonoBehaviour
{
    public RawImage image;
    public RawImage image2;
    public RawImage image3;
    public Text textAzimuth;
    public float moveSpeed = 10f;
    public float rotateSpeed = 100f;

    public float roll = 0;
    public float pitch = 0;
    public float azimuth = 0;
    public float currentPitch = 0;
    private float oldPitch = 0;


    // Update is called once per frame
    void Update()
    {
        float rotateInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float azimut = Input.GetAxis("Rotate");
        calculatePitch();
        if (currentPitch != oldPitch)
        {
            image.transform.Translate(new Vector3(0, -oldPitch, 0));
            image2.transform.Translate(new Vector3(0, -oldPitch, 0));
            image.transform.Translate(new Vector3(0, currentPitch, 0));
            image2.transform.Translate(new Vector3(0, currentPitch, 0));
            oldPitch = currentPitch;
        }
        // Move the RawImage
        // Rotate the RawImage
        //transform.Rotate(Vector3.forward, rotateInput * rotateSpeed * Time.deltaTime*-1);
        transform.rotation = Quaternion.Euler(0, 0, roll);
        //image3.transform.Rotate(Vector3.forward, azimut * rotateSpeed * Time.deltaTime * -1);
        image3.transform.rotation = Quaternion.Euler(0, 0, azimuth);
        textAzimuth.text = ((int)azimuth).ToString();
    }
    private void calculatePitch()
    {
        if (pitch > 180)
        {
            if (pitch < 320)
            {
                pitch = 320;
            }
            currentPitch = Map(pitch, 320, 360, 91,0);
        }
        else
        {
            if (pitch > 40)
            {
                pitch = 40;
            }
            currentPitch = Map(pitch, 0, 40, 0, -91);
        }
    }

    public static float Map(float value, float fromLow, float fromHigh, float toLow, float toHigh)
    {
        // Перетворення діапазону вхідних значень на діапазон 0-1
        double normalizedValue = (double)(value - fromLow) / (fromHigh - fromLow);

        // Перетворення діапазону 0-1 на вихідний діапазон
        float mappedValue = (float)(normalizedValue * (toHigh - toLow) + toLow);

        return mappedValue;
    }
}
