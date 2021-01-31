using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTopCollision : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
		{
		BallMovement.yspeed = -BallMovement.yspeed;
		BallMovement.colflag = true;
		}
	}
