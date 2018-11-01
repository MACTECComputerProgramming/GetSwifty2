using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossHealth_Slider : MonoBehaviour {
    public int bossHealthMax;
    public int bossHealthCurrent;
    public Slider healthBar_Boss;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        healthBar_Boss.value = CalculateHealth();

        if(bossHealthCurrent <= 0){
            Destroy(gameObject);
            ScoreScript.scoreValue += 500;
            SceneManager.LoadScene(3);
        }
        
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Bullet"))
        {
            bossHealthCurrent -= 25;
        }
    }

 float CalculateHealth()
    {
        return bossHealthCurrent;
    }

     }

