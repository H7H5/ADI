using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gorizont : MonoBehaviour
{
    public RawImage image;
    public float moveSpeed = 10f;
    public float rotateSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        float rotateInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        //float rotateInput = Input.GetAxis("Rotate");

        // Move the RawImage
        image.transform.Translate(new Vector3(0, verticalInput, 0) * moveSpeed * Time.deltaTime);

        // Rotate the RawImage
        image.transform.Rotate(Vector3.forward, rotateInput * rotateSpeed * Time.deltaTime*-1);
    }
}
