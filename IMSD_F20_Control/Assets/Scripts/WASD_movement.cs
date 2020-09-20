using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_movement : MonoBehaviour
{
    Transform myTransform;

    private float speed = 10;
    void Start()
    {
        myTransform = transform;
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            myTransform.position += new Vector3(0, Time.deltaTime * speed, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            myTransform.position += new Vector3(0, -Time.deltaTime * speed, 0);
        }
    }
}
