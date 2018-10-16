using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterContoller : MonoBehaviour {

    //running
    private Rigidbody2D rBody;
    public float runSpeed;
    //flipping
    private bool facingRight;

    //Jumping
    public float jumpforce;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private int extrajumps;
    public int extraJumpValue;

    /*Credit to:
     --- Blackthorneprod
     */

	// Use this for initialization
	void Start () {
        extrajumps = extraJumpValue;

        facingRight = true;
        rBody = GetComponent<Rigidbody2D>();
	}
	//------------------------------------------------------------------------------------------
	// Update is called once per frame
	void Update () {
        //Remember to make to parent 
        //if the W key is pressed it forces the Ridid body up and removes an extra jump
        if (isGrounded == true)
        {
            extrajumps = extraJumpValue;
        }

        if (Input.GetKeyDown(KeyCode.W) && extrajumps > 0)
        {
            rBody.velocity = Vector2.up * jumpforce;
            extrajumps--;
        }
        else if (Input.GetKeyDown(KeyCode.W) && extrajumps == 0 && isGrounded == true)
        {
            rBody.velocity = Vector2.up * jumpforce;
        }
     }
    //------------------------------------------------------------------
    void FixedUpdate ()
    {
        //Get A & D or leftright arrow buttons (A=-1, D=1)
       float horizontal = Input.GetAxis("Horizontal");

        HandleMovement(horizontal);

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
	}
    //---------------------------------------------------------
    private void HandleMovement(float horizontal)
    {
        //Multiply 1 or -1 by the adjustible runspeed
        rBody.velocity = new Vector2(horizontal * runSpeed, rBody.velocity.y);


         Flip(horizontal);
    }
    //----------------------------------------------------
//Fliping the Sprite on x axis
    private void Flip(float horizontal)
    {
          Vector3 v3 = new Vector3();

        if(horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;


            transform.Rotate(0f, 180f, 0f);
        }
       }
     }
    



