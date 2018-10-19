using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class AnimationControl : MonoBehaviour {

    public GameObject AnimatedGameObject;
    public Sprite[] AnimationSets;
    public int Cur_SpriteID;
    private float SecsPerFrame = 0.1f;

    public bool isGrounded;
    public Transform groundCheck;
    public LayerMask whatIsGround;
    public float checkRadius;
    private SpriteRenderer sr;


    void Start()
    {
        Cur_SpriteID = 0;
        if (!AnimatedGameObject)
        {
            AnimatedGameObject = this.gameObject;
        }
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        PlayAnimation(SecsPerFrame);
        
    }









    public void PlayAnimation(float secPerFrame)
    {
        SecsPerFrame = secPerFrame;
        StopCoroutine("AnimateSprite");

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
                        AnimatedGameObject.GetComponent<SpriteRenderer>().sprite = AnimationSets[2]; break;

                    case 1:
                        Cur_SpriteID = 2;
                        AnimatedGameObject.GetComponent<SpriteRenderer>().sprite = AnimationSets[2]; break;
                    case 2:
                        yield return new WaitForSeconds(SecsPerFrame);
                        Cur_SpriteID = 3;
                        AnimatedGameObject.GetComponent<SpriteRenderer>().sprite = AnimationSets[3]; break;

                    case 3:
                        yield return new WaitForSeconds(SecsPerFrame);
                        Cur_SpriteID = 2;
                        AnimatedGameObject.GetComponent<SpriteRenderer>().sprite = AnimationSets[2]; break;
                    
                    //default:
                      //  yield return new WaitForSeconds(SecsPerFrame);
                        //Cur_SpriteID = 2;
                        //AnimatedGameObject.GetComponent<SpriteRenderer>().sprite = AnimationSets[2]; break;
                }
            }
            else
            {
                AnimatedGameObject.GetComponent<SpriteRenderer>().sprite = AnimationSets[0];
                Cur_SpriteID = 0;
            }
        }
        else
        {
            AnimatedGameObject.GetComponent<SpriteRenderer>().sprite = AnimationSets[1];
            Cur_SpriteID = 1;
        }
    }











}