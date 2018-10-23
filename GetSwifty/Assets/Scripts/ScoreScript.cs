using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    public static int scoreValue; //Static score that gets changed by other classes
    Text score; //Gui text that will be displayed for the player

	//Sets the Gui text to the editor component
	void Start ()
    {
        score = GetComponent<Text>();
	}
	
	//Updates the text of the Gui every frame
	void Update ()
    {
        score.text = "Score: " + scoreValue;
	}
}
