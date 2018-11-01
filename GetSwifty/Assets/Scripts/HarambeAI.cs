using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarambeAI : MonoBehaviour {

    public int action;
    public bool inRush;
    public bool inBlast;
    public bool facingRight;
    
    public Rigidbody2D rb;
    
    public static int HarambeValue;
    public System.Random rn;
    
    void Start () {
        inRush = false;
        inBlast = false;
        facingRight = false;
        rb = GetComponent<Rigidbody2D>();
        rn = new System.Random();
        Debug.Log("start");
        StartCoroutine(GoGo());
    }


    private void BlastAttack()
    {
        
        
            Debug.Log("blast");
        
        
    }


    IEnumerator RushAttack()
    {
        inRush = true;
        //Get into position
        if (transform.position.x < 7)
        {
            //flips to right
            if (!facingRight)
            {
                FlipSprite();
            }
            //move to left to prep for rush            
            while (transform.position.x < 7)
            {
                Movement(1,4);
                yield return null;
            }
            //flips to left
            if (facingRight)
            {
                FlipSprite();
            }
            yield return new WaitForSeconds(1);
        }
        //Rush attack
        while(transform.position.x > -7)
        {
            Movement(-1, 10);
            yield return null;
        }
        yield return new WaitForSeconds(1);
        inRush = false;
    }



    private void Movement(int direction, int speed)
    {
        rb.velocity = new Vector2((speed * direction), rb.velocity.y);
    }


    private void FlipSprite()
    {
        Debug.Log("flip");
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }


    IEnumerator GoGo()
    {
        for (int i = 3; i > 0; i--)
        {
            action = rn.Next(0, 2);
            Debug.Log("action");
            if (action == 1)
            {
                BlastAttack();
                Debug.Log("Blast");
            }
            if (action == 0)
            {
                StartCoroutine(RushAttack());
                while (inRush)
                    yield return new WaitForSeconds(0.1f);
            }
            
            yield return new WaitForSeconds(2);
            Debug.Log("yes");
        }
    }









}
