using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour
{
    public Transform myTransform;
    private float speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKey(KeyCode.W))
        {
            myTransform.position += new Vector3(0, 0, Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            myTransform.position += new Vector3(-Time.deltaTime * speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            myTransform.position += new Vector3(0, 0, -Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            myTransform.position += new Vector3(Time.deltaTime * speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            myTransform.position += new Vector3(0, Time.deltaTime * speed, 0);
        }
    }
}
