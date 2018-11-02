using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarambeAnimation : MonoBehaviour {


    private Animator an;
    



	void Start () {
        an = GetComponent<Animator>();
        
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
