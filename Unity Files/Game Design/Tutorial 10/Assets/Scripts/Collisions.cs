using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
		{
		if (collision.collider.tag == "Player") { 
			
			}
		if (collision.collider.tag == "Bullet") {
				Destroy(collision.collider.gameObject);
				Destroy(gameObject);
			}
		}
	}
