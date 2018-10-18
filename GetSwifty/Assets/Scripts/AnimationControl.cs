using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour {

    public Sprite jumpSprite;
    public Sprite restSprite;
    public Sprite runSprite1;
    public Sprite runSprite2;


    private bool isGrounded;
    public Transform groundCheck;
    public LayerMask whatIsGround;
    public float checkRadius;
    private SpriteRenderer sr;

    // Use this for initialization
    void Start () {
        sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        ChangeSprite();
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
    }





    public void ChangeSprite()
    {
        if (isGrounded)
        {
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
            {
                if (sr.sprite == runSprite1)
                {
                    sr.sprite = runSprite2;
                }
                else
                {
                    sr.sprite = runSprite1;
                }
            }
            else
            {
                sr.sprite = restSprite;
            }
        }
        else if (!isGrounded)
        {
            sr.sprite = jumpSprite;
        }
        else
        {
            sr.sprite = jumpSprite;
        }
    }





}
