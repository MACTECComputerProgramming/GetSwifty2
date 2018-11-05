using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour {

    public bool isMoving; //Value to display if the player is moving
    public bool isGrounded; //Value to display if the player is on the ground
    public Transform groundCheck; //Empty object detecting layered ground
    public LayerMask whatIsGround; //Layer that is considered ground
    public float checkRadius; //Used to detect if the player is touching the ground
    public SpriteRenderer sr; //Renderer that gets adjusted
    public Animator an; //Animator whose parameters get changed

    void Start()
    { 
        //Assigns the renderer and the animator
        sr = GetComponent<SpriteRenderer>();
        an = GetComponent<Animator>();
    }

    void Update()
    {
        //Uses a circle, a transform, and a layer to check if the player is touching the ground
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        //Detects if the player is touching the ground
        if (isGrounded)
        {
            an.SetBool("Grounded", true);
        }
        if (!isGrounded)
        {
            an.SetBool("Grounded", false);
        }

        //Detects if the player is pressing the keys and therefore moving
        if (Input.GetKey(KeyCode.A))
        {
            an.SetBool("Moving", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            an.SetBool("Moving", true);
        }

        //Detects if the player is not pressing any movement keys
        if (!(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {
            an.SetBool("Moving", false);
        }
    }
}