using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Timeline;


public class AnimationControl : MonoBehaviour {

    public bool isGrounded; //Value to detect whether the player is on the ground
    public Transform groundCheck; //Empty object detecting layered ground
    public LayerMask whatIsGround; //Layer that is considered ground
    public float checkRadius; 
    private SpriteRenderer sr; //Renderer that gets adjusted
    public Animator an;
    public Rigidbody2D rb;

    void Start()
    {
        
              
        sr = GetComponent<SpriteRenderer>();

        an = GetComponent<Animator>();

        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        

        if (isGrounded)
        {
            an.SetBool("Grounded", true);
        }
        if (!isGrounded)
        {
            an.SetBool("Grounded", false);
        }

        an.SetFloat("Speed", rb.velocity.x);
       
    }


}