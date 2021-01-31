using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour {

    public GameObject Projectile;
    public float nextFire;
    public float fireRate = 0.4f;
    public static float Ammo = 20.0f;
    public static float MaxAmmo = 20.0f;

	// Update is called once per frame
	void Update () {
		//0-> left button (mouse), 1 -> right button(mouse)
        //checking if the player clicked on the left mouse button
        //and they delay between fires is up and that there's enough ammo
        if(Input.GetMouseButtonDown(0) && Time.time > nextFire && Ammo > 0)
        {
            nextFire = Time.time + fireRate;
            Ammo -= 1.0f;

            //instantiate function is used to create clones of prefabs 
            //which in our case would be the bullet
            Instantiate(Projectile, transform.position, transform.rotation);
        }

        if (Input.GetKey(KeyCode.R))
        {
            Ammo = MaxAmmo;
        }
	}
}
