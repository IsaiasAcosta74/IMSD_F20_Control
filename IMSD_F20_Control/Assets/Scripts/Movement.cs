using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform myTransform;

    public float speed;
    void Start()
    {
        myTransform.position = new Vector3(-10, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position =
            myTransform.position + new Vector3(1, 0, 0) * speed * Time.deltaTime;
    }
}
