﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject flexSeal_Spray;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
}
        void Shoot(){
            Instantiate(flexSeal_Spray, firePoint.position, firePoint.rotation);
        }
	
}
