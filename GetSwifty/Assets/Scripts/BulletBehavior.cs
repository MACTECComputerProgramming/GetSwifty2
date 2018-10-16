using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {


    public float bulletSpeed;
    public Rigidbody2D rBody;
    public GameObject Bullet;
    
    


	// Use this for initialization
	void Start () {
        rBody.velocity = transform.right * bulletSpeed; 
	}
    void Update()
    {
        Destroy(Bullet, .25f);
    }


	void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Destroy(gameObject); 
    }	



}
