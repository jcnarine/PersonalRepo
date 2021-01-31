using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float distance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y + 4, target.transform.position.z - distance);
    }
}
