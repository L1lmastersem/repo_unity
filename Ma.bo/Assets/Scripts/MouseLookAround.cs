using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookAround : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;

    Rigidbody rb;

    public float sensitivity = 15f;
    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
        rotationX = Mathf.Clamp(rotationX, -90, 90);

        Debug.Log("rotX"+rotationX);
        transform.rotation = Quaternion.Euler(new Vector3(rotationX, rotationY, 0));

        //rb.rotation = transform.rotation;
    }
}