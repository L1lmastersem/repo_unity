using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float _movementSpeed = 10000f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.AddForce(transform.forward * (Time.deltaTime * _movementSpeed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.AddForce(transform.forward * -(Time.deltaTime * _movementSpeed));
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(-transform.right * (Time.deltaTime * _movementSpeed));
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(transform.right * (Time.deltaTime * _movementSpeed));
        }
        //float mx = Input.GetAxis("Mouse X");
    }
}
 