using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossHealth_Slider : MonoBehaviour {

    public int bossHealthMax; //Value of the boss's max health
    public int bossHealthCurrent; //Value of boss's current health
    public Slider healthBar_Boss; //Slider that will represent the boss's health in game
    

	void Update () {
        //Changes the slider's value
        healthBar_Boss.value = CalculateHealth();

        //Detects when the boss dies and adds score and sends you to the win screen
        if(bossHealthCurrent <= 0){
            Destroy(gameObject);
            ScoreScript.scoreValue += 500;
            SceneManager.LoadScene(3);
        }
	}

    //Detects when the boss collides with the bullet and does damage to it
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Bullet"))
        {
            bossHealthCurrent -= 25;
        }
    }

    //Gives the boss's health
    float CalculateHealth()
    {
        return bossHealthCurrent;
    }

}