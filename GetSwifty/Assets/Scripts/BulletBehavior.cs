using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {

    //How fast the bullet travels
    public float bulletSpeed;
    //Rigidbody controller on the bullet
    public Rigidbody2D rBody;
    //Actual bullet object being created and destroyed
    public GameObject Bullet;


	//Called when the bullet is created, adds a force to the bullet
	void Start () {
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
