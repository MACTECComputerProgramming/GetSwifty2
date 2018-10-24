using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform firePoint; //Origin of bullets on the sprite, uses an empty
    public GameObject flexSeal_Spray; //Bullet being fired
	
	//Detects every frame if the spacebar is pressed and then calls the shoot method
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    //Kyler was here
    //Method creates a bullet at the point indicated and sets its position and rotation
    void Shoot()
    {
        Instantiate(flexSeal_Spray, firePoint.position, firePoint.rotation);
    }
	
}
