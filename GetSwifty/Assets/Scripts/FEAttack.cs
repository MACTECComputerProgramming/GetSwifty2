﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FEAttack : MonoBehaviour {
    //public Transform firePoint;
    public GameObject Bullet;
    public float playerRange;
    public CharacterContoller player;
    public Transform launchPoint;
    public float waitBetweenShots;
    private float shotCounter;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<CharacterContoller>();

        shotCounter = waitBetweenShots;

	}
	
	// Update is called once per frame
	void Update () {
        
        shotCounter -= Time.deltaTime;

        if (transform.position.y - player.transform.position.y > -2 
                &&transform.position.y - player.transform.position.y < 2
                && shotCounter < 0)
        {
            Instantiate(Bullet, launchPoint.position, launchPoint.rotation);
            shotCounter = waitBetweenShots;
        }


        if (transform.position.y - player.transform.position.y > -2
            && transform.position.y - player.transform.position.y < 2 && shotCounter < 0)
        {
            Instantiate(Bullet, launchPoint.position, launchPoint.rotation);
            shotCounter = waitBetweenShots;
        } 
    }
}
        



   

