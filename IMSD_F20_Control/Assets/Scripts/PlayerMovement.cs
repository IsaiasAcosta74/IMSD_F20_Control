using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool moveByVelocity;

    public float moveSpeed;
    public float jumpSpeed;

    float movement;
    float offset;

    bool jumpFlag;
    bool isGrounded;

    Rigidbody rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        
        offset = movement * (moveSpeed * Time.deltaTime);
        if (moveByVelocity)
        {
            MoveByVelocity();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpFlag = true;
        }
    }

    private void FixedUpdate()
    {
        if(jumpFlag == true && moveByVelocity == true)
            if (isGrounded)
            {
                rigidBody.velocity = new Vector3(rigidBody.velocity.x, jumpSpeed * Time.deltaTime);
            }
        jumpFlag = false;
        if (moveByVelocity)
        {
            MoveByVelocity();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
    void MoveByVelocity()
    {
        moveSpeed = 100;
        jumpSpeed = 600;

        if (movement != 0)
        {
            rigidBody.velocity = new Vector3(Input.GetAxis("Horizontal")* moveSpeed, 0, Input.GetAxis("Vertical")* moveSpeed);
        }
        else
        {
            rigidBody.velocity = new Vector3(0, rigidBody.velocity.y);
        }
    }

}
