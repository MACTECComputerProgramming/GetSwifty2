using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehave_Enemy : MonoBehaviour {

    
    public Rigidbody2D rBody;
    public GameObject Bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(Bullet, 5f);
	}
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Destroy(gameObject);
    }
}
