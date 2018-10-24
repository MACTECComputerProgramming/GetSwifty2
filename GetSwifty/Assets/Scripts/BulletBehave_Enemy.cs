using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehave_Enemy : MonoBehaviour {

    
    public Rigidbody2D rBody;
    public GameObject Bullet;
    public int destroyOverTime;

	// Use this for initialization
	void Start () {
	
	}
<<<<<<< HEAD
	
	// Update is called once per frame
	void Update () {
        Destroy(Bullet, destroyOverTime);
=======
    //Kyler was here
    // Update is called once per frame
    void Update () {
        Destroy(Bullet, 5f);
>>>>>>> a985859b094f6c06d70b782666ed1f90ce50d0f1
	}
    void OnTriggerEnter2D(Collider2D hitInfo)
    {


        if( !(hitInfo.gameObject.tag.Equals("Enemy")) ){
        Destroy(gameObject);
        }
    }
}
