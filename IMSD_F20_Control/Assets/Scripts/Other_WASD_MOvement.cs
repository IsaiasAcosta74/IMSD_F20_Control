using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Other_WASD_MOvement : MonoBehaviour
{
    public Transform myTransform;

    private float speed = 2;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            myTransform.position += Vector3.right *speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            myTransform.position += Vector3.left*speed;
        }
    }
}
