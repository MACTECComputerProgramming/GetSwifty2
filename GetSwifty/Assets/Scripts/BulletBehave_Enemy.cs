using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehave_Enemy : MonoBehaviour {
    
    public Rigidbody2D rBody; //Enemy bullet's rigidbody
    public GameObject Bullet; //Enemy bullet's prefab
    public int destroyOverTime; //Time bullet exists before being destroyed
    public float bulletSpeed; //Enemy bullet's speed

    //Set's the bullet's velocity as soon as it's created
	void Start () {
        rBody.velocity = transform.right * bulletSpeed;
	}
	

    void Update()
    {
        //Destroys the bullet over time
        Destroy(Bullet, destroyOverTime);
    }
    
    //Destroys the bullet if it touches an enemy
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(!(hitInfo.gameObject.tag.Equals("Enemy"))) {
        Destroy(gameObject);
        }
    }
}
