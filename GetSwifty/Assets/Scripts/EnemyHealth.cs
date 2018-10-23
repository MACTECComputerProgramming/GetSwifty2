using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyHealth; //Value of enemy's health

    //Checks every frame if the enemy's health is at or below 0 and destroys if it is
    void Update()
    {
        if(enemyHealth <= 0)
        {
            Destroy(gameObject);
            ScoreScript.scoreValue += 50;
        }
    }
    
    //When triggered checks if the collider's tag is bullet and if true then takes off some health
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Bullet"))
        {
            
            enemyHealth -= 25;
        }
    }



}

   

