using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour {
    public float ProjectileSpeed = 20.0f;
    public float LifeSpan = 5.0f;
    private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
    void FixedUpdate()
    {
        rigidbody.AddForce(transform.forward * ProjectileSpeed, ForceMode.Impulse);
    }

	// Update is called once per frame
	void Update () {
        Destroy(gameObject, LifeSpan);
	}
}
