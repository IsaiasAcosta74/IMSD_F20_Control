using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform myTransform;

    public float speed;

    private float timer;
    void Start()
    {
        myTransform.position = new Vector3(-10, 0, 0);
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // myTransform.position =
        // myTransform.position + new Vector3(1, 0, 0) * speed * Time.deltaTime;

        timer += Time.deltaTime;
        if(timer >= 1)
        {
            timer = 0;
            myTransform.position += new Vector3(1, 0, 0);
        }
    }
}
