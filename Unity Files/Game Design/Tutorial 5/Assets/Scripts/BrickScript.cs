using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class BrickScript : MonoBehaviour
    {
    private void OnTriggerEnter(Collider other)
        {
        if (BallMovement.colflag == true)
            {
            BallMovement.yspeed = -BallMovement.yspeed;
            BallMovement.colflag = false;
            UI_Manager.score += 100;
            Destroy(gameObject);
            }
        }
    }
