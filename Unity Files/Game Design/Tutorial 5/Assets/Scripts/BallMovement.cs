using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public static float launchTimer = -2.0f;
    public static float xspeed = -8.0f;
    public static float yspeed = -8.0f;
    public static bool colflag = true;
    void Start()
    {
        InvokeRepeating("SpeedUp", 2.0f, 0.3f);
    }

    public void SpeedUp() {
        if (xspeed < 0) { xspeed -= 0.1f; } else { xspeed += 0.1f; }
        if (yspeed < 0) { yspeed -= 0.1f; } else { yspeed += 0.1f; }
     }
    // Update is called once per frame
    void Update()
    {
        launchTimer -= Time.deltaTime;

        if (launchTimer <=0) 
            {
            transform.Translate(new Vector3(xspeed, yspeed, 0) * Time.deltaTime);
            launchTimer = 0.0f;
            }
    }
}
