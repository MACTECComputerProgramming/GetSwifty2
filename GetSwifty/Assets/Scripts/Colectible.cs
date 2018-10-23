using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colectible : MonoBehaviour {

    //When triggered checks the collider for the player tag and if true adds ten to the score and destroys itself
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            ScoreScript.scoreValue += 10;
            Destroy(gameObject);
        }
    }
}
