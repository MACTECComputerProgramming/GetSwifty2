using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FEAttack : MonoBehaviour {
    public Transform firePoint;
    public GameObject Bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.Mouse1))
        {
          Drop();	
        }
        //Kyler was here
    }

    void Drop()
    {
        Instantiate(Bullet , firePoint.position, firePoint.rotation);
    }
}
