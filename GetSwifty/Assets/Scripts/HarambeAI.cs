using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarambeAI : MonoBehaviour {

    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public Rigidbody2D rb;
    public LayerMask whatIsGround;
    public static int HarambeValue;
    
    void Start () {
		
	}
	
	
	void Update () {
        System.Random rn = new System.Random();

        int x = rn.Next(0, 2);
        HarambeValue = x;
        if (x == 1)
        {
            
            //do blast attack
        }




	}
}
