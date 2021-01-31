using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollisions : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
		{
		BallMovement.xspeed = -BallMovement.xspeed;
		BallMovement.colflag = true;
		}
	}
