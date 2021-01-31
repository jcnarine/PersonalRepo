using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public float movementSpeed = 10.0f;
    public float turningSpeed = 10.0f;
	
	// Update is called once per frame
	void Update () {
        
        //Horizontal zxis -> left and right keys (or A and D)
        float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        //Vertical Axis -> up and down keys (or W and S)
        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
	}
}
