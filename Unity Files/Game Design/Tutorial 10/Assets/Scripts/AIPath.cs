using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPath : MonoBehaviour
{
    public GameObject[] Nodes = new GameObject[5];
    public float Speed = 5.0f;

    private int PathProgress = 0;
    private float DistanceBetweenObject;
    private float Diff = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<Nodes.Length; i++) {
            Nodes[i] = GameObject.Find("Node " + i);
            }
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Nodes[PathProgress].transform.position);
        DistanceBetweenObject = Vector3.Distance(Nodes[PathProgress].transform.position, transform.position);
        
        if (DistanceBetweenObject > Diff || DistanceBetweenObject == Diff)
            {
            transform.position += transform.forward * Speed * Time.deltaTime;
            }

        else if (DistanceBetweenObject < Diff && PathProgress < Nodes.Length) 
            {
            PathProgress++;
            }
    }
}
