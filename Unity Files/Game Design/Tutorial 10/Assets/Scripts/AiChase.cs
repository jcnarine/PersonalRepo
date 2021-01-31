using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiChase : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Player;
    public float Speed = 10.0f;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);

        transform.position += transform.forward * Speed * Time.deltaTime;
    }
}
