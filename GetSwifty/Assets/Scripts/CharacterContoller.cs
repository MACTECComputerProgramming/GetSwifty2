using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterContoller : MonoBehaviour {

    //running
    private Rigidbody2D rBody; //Player's rigidbody
    public float runSpeed; //Player's runspeed
    //flipping
    private bool facingRight; //The player's rotation

    //Jumping
    public float jumpforce; //Force of the player's jump
    private bool isGrounded; //Bool storing if the player's grounded
    public Transform groundCheck; //Empty placed at player's feet to detect if grounded
    public float checkRadius; //Used to detect if grounded
    public LayerMask whatIsGround; //Layer to ask what ground is
    private int extrajumps; //Amount of jumps the player has
    public int extraJumpValue; //Amount of jumps the player has

    /*Credit to:
     --- Blackthorneprod
    */

	//sets extra jumps, sets the bool that faces right, and finds the player's rigidbody
	void Start ()
    {
        extrajumps = extraJumpValue;

        facingRight = true;
        rBody = GetComponent<Rigidbody2D>();
	}
	

    //Every frame checks if grounded and adds jumps back if true plus removes them and adds force if w is pressed
	void Update ()
    {
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
    

    //Every frame gets the horizontal face and uses it to move and checks if the player is grounded
    void FixedUpdate ()
    {
        //Get A & D or leftright arrow buttons (A=-1, D=1)
        float horizontal = Input.GetAxis("Horizontal");

        HandleMovement(horizontal);

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
	}


    //Method that adds force to the player's rigidbody and flips
    private void HandleMovement(float horizontal)
    {
        //Multiply 1 or -1 by the adjustible runspeed
        rBody.velocity = new Vector2(horizontal * runSpeed, rBody.velocity.y);
        Flip(horizontal);
    }
    
        
    //Fliping the Sprite on x axis when needed
    private void Flip(float horizontal)
    {
        if(horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;


            transform.Rotate(0f, 180f, 0f);
        }
    }
}
    



