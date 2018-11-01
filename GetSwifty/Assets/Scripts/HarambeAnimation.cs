using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarambeAnimation : MonoBehaviour {

    private SpriteRenderer sr;
    private Animator an;
    private Rigidbody2D rb;



	void Start () {
        sr = GetComponent<SpriteRenderer>();
        an = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
	}
	
	
	void Update () {
        if (HarambeAI.HarambeValue == 0)
        {
            an.SetInteger("Action", 0);
        }
        if (HarambeAI.HarambeValue == 1)
        {
            an.SetInteger("Action", 1);
        }
	} 
}
