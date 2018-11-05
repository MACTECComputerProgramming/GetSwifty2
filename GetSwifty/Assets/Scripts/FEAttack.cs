﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FEAttack : MonoBehaviour {
    

    public GameObject Bullet;
    public float playerRange;
    public CharacterContoller player;
    public Transform launchPoint;
    public float waitBetweenShots;
    private float shotCounter;

	//Finds the player and sets the shot counter
	void Start ()
    {
		player = FindObjectOfType<CharacterContoller>();
        shotCounter = waitBetweenShots;
	}
	
	
	void Update () {
        
        //Sets the counter
        shotCounter -= Time.deltaTime;

        //Shoot bullets
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
        



   

