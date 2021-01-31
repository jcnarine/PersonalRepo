using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBricks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (float y = 0; y<8; y++) 
        {

            for (float x = 0; x<14; x++) 
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(x * 2f -13.0f, y-1f, -1f);
                cube.transform.localScale = new Vector3(1.9f, 0.9f, 1.0f);
                cube.GetComponent<Collider>().isTrigger = true;
                cube.AddComponent<BrickScript>();

                if (y < 2) {
                    cube.GetComponent <Renderer>().material.color = Color.yellow;
                    }
                else if (y < 4) { 
                    cube.GetComponent <Renderer>().material.color = Color.cyan;
                    }
                else if (y < 6) { 
                    cube.GetComponent <Renderer>().material.color = Color.blue;
                    }
                else
                    {
                    cube.GetComponent<Renderer>().material.color = Color.red;
                    }
                }

        }
    }
}
