﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarambeAI : MonoBehaviour {

    public int action;
    public bool inRush;
    public bool inBlast;
    public bool facingRight;
    public bool touchingPlayer;

    public Rigidbody2D rb;

    public Transform blastPoint1;
    public Transform blastPoint2;
    public Transform blastPoint3;
    public GameObject blast;

    public GameObject player;
    public static int HarambeValue;
    public System.Random rn;

    public AudioClip grunt;
    public AudioClip fireball;
    public AudioSource au;
    
    void Start () {
        inRush = false;
        inBlast = false;
        facingRight = false;
        touchingPlayer = false;
        rb = GetComponent<Rigidbody2D>();
        rn = new System.Random();
        au = GetComponent<AudioSource>();
        Debug.Log("start");
        StartCoroutine(GoGo());
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            touchingPlayer = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            touchingPlayer = false;
        }
    }



    IEnumerator BlastAttack()
    {
        inBlast = true;

        if (player.transform.position.x - transform.position.x > 0 && !facingRight)
        {
            FlipSprite();
        }
        if (player.transform.position.x - transform.position.x < 0 && facingRight)
        {
            FlipSprite();
        }
        au.PlayOneShot(fireball);
        Instantiate(blast, blastPoint1.position, blastPoint1.rotation);
        yield return new WaitForSeconds(0.5f);
        au.PlayOneShot(fireball);
        Instantiate(blast, blastPoint2.position, blastPoint2.rotation);
        yield return new WaitForSeconds(0.5f);
        au.PlayOneShot(fireball);
        Instantiate(blast, blastPoint3.position, blastPoint3.rotation);
        yield return new WaitForSeconds(2);


        

        inBlast = false;
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
            yield return new WaitForSeconds(0.25f);
        }
        //Rush attack
        au.PlayOneShot(grunt);
        while(transform.position.x > -7)
        {
            if (touchingPlayer)
            {
                break;
            }
            Movement(-1, 10);
            yield return null;
        }
        yield return new WaitForSeconds(1);
        inRush = false;
    }


    //Movement method
    private void Movement(int direction, int speed)
    {
        rb.velocity = new Vector2((speed * direction), rb.velocity.y);
    }

    //Flip method
    private void FlipSprite()
    {
        Debug.Log("flip");
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }


    IEnumerator GoGo()
    {
        for (int i = 1000; i > 0; i--)
        {
            action = rn.Next(0, 2);
            HarambeValue = action;
            Debug.Log("action");
            if (action == 1)
            {
                Debug.Log("Blast");
                StartCoroutine(BlastAttack());
                while (inBlast)
                    yield return new WaitForSeconds(0.1f);
            }
            if (action == 0)
            {
                Debug.Log("Rush");
                StartCoroutine(RushAttack());
                while (inRush)
                    yield return new WaitForSeconds(0.1f);
            }
            HarambeValue = action;
            yield return new WaitForSeconds(0.5f);
            Debug.Log("yes");
        }
    }









}
