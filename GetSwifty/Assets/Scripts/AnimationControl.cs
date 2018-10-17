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
        if (isGrounded)
        {
            sr.sprite = restSprite;
        }
        if (!isGrounded)
        {
            sr.sprite = jumpSprite;
        }
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
    }
}
