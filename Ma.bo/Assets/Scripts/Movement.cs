using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputHor = Input.GetAxis("Horizontal");
        if (inputHor != 0 )
        {
            gameObject.transform.Rotate(0, inputHor, 0);
        }
        else
        {

        }
    }
}
