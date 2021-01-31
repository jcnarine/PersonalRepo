using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 10.0f;
    public float turningSpeed = 10.0f;

    public ParticleSystem ps_thruster_forward;
    public ParticleSystem ps_thruster_backward;

    public AudioSource sound;

    Rigidbody2D rigidBody;
    Vector2 input;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float torque = Input.GetAxis("Horizontal") * turningSpeed;
        rigidBody.AddTorque(-torque);
        Vector2 force = transform.up * movementSpeed;
        force *= Input.GetAxis("Vertical");
        rigidBody.AddForce(force);

        if (Input.GetAxis("Vertical") > 0.0f) {
            if (!ps_thruster_forward.isPlaying) {
                ps_thruster_forward.Play();
                sound.Play();
                }
            ps_thruster_backward.Stop();
            }
        if (Input.GetAxis("Vertical") < 0.0f) { 
            
            if (!ps_thruster_backward.isPlaying) { 
                ps_thruster_backward.Play();
                sound.Play();
                }
            ps_thruster_forward.Stop();
            }
    }
}