using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trump : MonoBehaviour
{
    Animator anim;

    public float movementSpeed = 10.0f;
    public float turningSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        transform.Translate(horizontal, 0, 0);
        
        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);

        if (Input.GetAxis("Vertical") > 0.0f)
            {
            anim.SetInteger("StateValue", 1);
            }
        else if (Input.GetAxis("Vertical") < 0.0f)
            {
            anim.SetInteger("StateValue", 3);
            }
        else if (Input.GetAxis("Horizontal") > 0.0f)
            {
            anim.SetInteger("StateValue", 4);
            }
        else if (Input.GetAxis("Horizontal") < 0.0f)
            {
            anim.SetInteger("StateValue", 5);
            }
        else {
            anim.SetInteger("StateValue", 0);
            }
    }
}
