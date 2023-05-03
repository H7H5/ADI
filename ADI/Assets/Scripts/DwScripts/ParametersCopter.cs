using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParametersCopter : MonoBehaviour
{
    public GameObject motor;
    private float motorHeigth;

    private Rigidbody rigidbody;

    //������
    public float altitude;

    //��������
    public float speed;

    //������
    public float pitch;
    //����
    public float roll;
    //��������
    public float yaw;

    void Start()
    {
        motorHeigth = motor.transform.localScale.y / (2 * 10);
        rigidbody = transform.GetComponent<Rigidbody>();
    }

    void Update()
    {
        altitude = transform.position.y - motorHeigth;
        pitch = transform.rotation.eulerAngles.x;
        roll = transform.rotation.eulerAngles.z;
        yaw = transform.rotation.eulerAngles.y;

        speed = rigidbody.velocity.magnitude;
        //Debug.Log(transform.GetComponent<Rigidbody>().velocity.magnitude);
    }
}
