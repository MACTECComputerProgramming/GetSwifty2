using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarambeAI : MonoBehaviour {

    public bool idle;
    public int action;
    
    
    
    public Rigidbody2D rb;
    
    public static int HarambeValue;
    public System.Random rn;
    
    void Start () {
        idle = true;
        rb = GetComponent<Rigidbody2D>();
        rn = new System.Random();
        Debug.Log("start");
        GoGo();
    }
	
    
	
	void Update () {
      /*  Debug.Log("update start");
        action = rn.Next(0, 2);
        
        if (idle == true)
        {
            Debug.Log("action");
            if (action == 1)
            {
                BlastAttack();
                Debug.Log("Blast");
            }
            if (action == 0)
            {
                RushAttack();
            }
        }
        else
        {
            Debug.Log("idle");
        }
        */       Debug.Log("Update end");
	}
    


    private void BlastAttack()
    {
        idle = false;
        
            Debug.Log("blast");
        
        idle = true;
    }


    private void RushAttack()
    {
        idle = false;
        //Get into position
        if (transform.position.x < 7)
        {
            if (transform.rotation.y == 180)
            {
                FlipSprite();
            }

            float a = 7 ;
            for (float i = a; i > 0;i--)
            {
                Movement(1,4);
            }

            if (transform.rotation.y == 0)
            {
                FlipSprite();
            }
        }
        //Rush attack
        for(int i = 14; i > 0 ; i--)
        {
            Movement(-1, 2);
        }
        Debug.Log("rush");
        idle = true;
    }



    private void Movement(int direction, int speed)
    {
        rb.velocity = new Vector2((speed * direction), rb.velocity.y);
    }


    private void FlipSprite()
    {
        if (transform.rotation.y == 180)
        {
            transform.rotation = new Quaternion(transform.rotation.x, 0, transform.rotation.z, transform.rotation.w);
        }
        else
        {
            transform.rotation = new Quaternion(transform.rotation.x, 180, transform.rotation.z, transform.rotation.w);
        }
    }

    private void GoGo()
    {

        for (int i = 60; i > 0 ; i--)
        {
            action = rn.Next(0, 2);
            if (idle == true)
            {
                Debug.Log("action");
                if (action == 1)
                {
                    BlastAttack();
                    Debug.Log("Blast");
                }
                if (action == 0)
                {
                    RushAttack();
                }
            }
            else
            {
                Debug.Log("idle");
            }

        }



    }











}
