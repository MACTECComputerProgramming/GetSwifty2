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
	// Update is called once per frame
    void Update()
    {
        Destroy(Bullet, destroyOverTime);
    }
    // Update is called once per frame
    
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if( !(hitInfo.gameObject.tag.Equals("Enemy")) ){
        Destroy(gameObject);
        }
    }
}
