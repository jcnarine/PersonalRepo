using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) 
            {
            transform.Translate(-50f * Time.deltaTime, 0, 0);
            }

        if (Input.GetKey(KeyCode.RightArrow)) 
            {
            transform.Translate(50f * Time.deltaTime, 0, 0);
            }

        float h = 80.0f * Time.deltaTime * Input.GetAxis("Mouse X");
        transform.Translate(h,0,0);

        if (transform.position.x>12)
            {
            transform.position = new Vector3(12, -15, player.transform.position.z);
            }
        else if (transform.position.x<-12)
            {
            transform.position = new Vector3(-12, -15, player.transform.position.z);
            }
    }

	private void OnTriggerEnter(Collider other)
		{
            BallMovement.yspeed = -BallMovement.yspeed;

        if (other.gameObject.transform.position.x > gameObject.transform.position.x)
            {
            BallMovement.xspeed = Mathf.Abs(BallMovement.xspeed);
            }
        else {
            BallMovement.xspeed = -Mathf.Abs(BallMovement.xspeed);
            }
        BallMovement.colflag = true;
		}
	}
