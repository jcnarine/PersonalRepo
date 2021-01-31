using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rigidbody;

    public float speed = 10.0f;
    public float jumpforce = 10.0f;
    public float gravityMult = 5.0f;

    bool isGrounded = false;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * jumpforce, ForceMode.VelocityChange);
        }
    }

    void FixedUpdate(){

        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(Vector3.right * speed);
        }

        if (!isGrounded) 
        {
            rigidbody.AddForce(Physics.gravity * gravityMult, ForceMode.Acceleration);
        
        }

    }

    void OnCollisionEnter(Collision Other)
    {

        Ground ground = Other.gameObject.GetComponent<Ground>();
        if (ground)
        {
            isGrounded = true;
        }
            
    }

    void OnCollisionExit(Collision other) 
    {

        Ground ground = other.gameObject.GetComponent<Ground>();

        if (ground)
        {
            isGrounded = false;
        }
    
    }
}
