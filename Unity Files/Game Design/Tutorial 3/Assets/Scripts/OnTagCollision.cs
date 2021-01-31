using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTagCollision : MonoBehaviour
{
    private void Awake() 
    {
        DontDestroyOnLoad(gameObject);
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider.tag == "cube" || collision.collider.tag == "sphere")
        {
            Destroy(gameObject);
        }
    }
}
