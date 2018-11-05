using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {

    public float bulletSpeed; //How fast the bullet travels
    public Rigidbody2D rBody; //Rigidbody controller on the bullet
    public GameObject Bullet;//Actual bullet object being created and destroyed
    

	//Called when the bullet is created, adds a force to the bullet
	void Start ()
    {
        rBody.velocity = transform.right * bulletSpeed; 
	}
    

    //After a set amount of seconds, destroys the bullet
    void Update()
    {
        Destroy(Bullet, .25f);
    }
    

    //Destroys the bullet when it hits an enemy collider
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.tag.Equals("Enemy"))
        {
            Debug.Log(hitInfo.name);
            Destroy(gameObject);
        }
    }	
}
