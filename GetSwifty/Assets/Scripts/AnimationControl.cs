using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Timeline;


public class AnimationControl : MonoBehaviour {

    public GameObject AnimatedGameObject; //Object being animated
    public Sprite[] AnimationSets; //All the sprites of the animation
    public int Cur_SpriteID; //Helps iterate through the sprites
    private float SecsPerFrame = 1f; //How long between running frames
    public bool isGrounded; //Value to detect whether the player is on the ground
    public Transform groundCheck; //Empty object detecting layered ground
    public LayerMask whatIsGround; //Layer that is considered ground
    public float checkRadius; //
    private SpriteRenderer sr; //Renderer that gets adjusted


    void Start()
    {
        //Sets the current sprite to zero and detects the gameobject
        Cur_SpriteID = 0;
        AnimatedGameObject = this.gameObject;
        sr = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        PlayAnimation(SecsPerFrame);
        
    }



    

    public void PlayAnimation(float secPerFrame)
    {
        
        

        StartCoroutine("AnimateSprite", isGrounded);
        
    }


    
    


    IEnumerator AnimateSprite(bool grounded)
    {
        
        if (grounded)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                switch (Cur_SpriteID)
                {
                    case 0:
                        Cur_SpriteID = 2;
                        sr.sprite = AnimationSets[2];
                        yield return new WaitForSeconds(SecsPerFrame);
                        StopCoroutine("AnimateSprite");
                        break;
                    case 1:
                        Cur_SpriteID = 2;
                        sr.sprite = AnimationSets[2];
                        yield return new WaitForSeconds(SecsPerFrame);
                        StopCoroutine("AnimateSprite");
                        break;
                    case 2:
                        Cur_SpriteID = 3;
                        sr.sprite = AnimationSets[3];
                        yield return new WaitForSeconds(SecsPerFrame);
                        StopCoroutine("AnimateSprite");
                        break;

                    case 3:
                        Cur_SpriteID = 2;
                        sr.sprite = AnimationSets[2];
                        yield return new WaitForSeconds(SecsPerFrame);
                        StopCoroutine("AnimateSprite");
                        break;
                    default:
                        yield return new WaitForSeconds(SecsPerFrame);
                        Cur_SpriteID = 0;
                        sr.sprite = AnimationSets[0];
                        StopCoroutine("AnimateSprite");
                        break;
                }
            }
            else
            {
                sr.sprite = AnimationSets[0];
                Cur_SpriteID = 0;
                StopCoroutine("AnimateSprite");
            }
        }
        else
        {
            sr.sprite = AnimationSets[1];
            Cur_SpriteID = 1;
            StopCoroutine("AnimateSprite");
        }
    }











}