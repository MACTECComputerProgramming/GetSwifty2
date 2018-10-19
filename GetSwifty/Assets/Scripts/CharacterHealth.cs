using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealth : MonoBehaviour {

    public int playerHealthMax;
    public int playerHealthCurrent;
    public Slider healthBar;
    
	
	void Start () {
        
        
    }
	
	// Update is called once per frame
	void Update() {
        

        if (playerHealthCurrent <= 0)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            StartCoroutine(Damage());
            
        }
        
       
    }
    void OnTriggerExit(Collider other)
    {
        StopCoroutine(Damage());
    }

    IEnumerator Damage()
    {
        playerHealthCurrent -= 25;
        healthBar.value = CalculateHealth();
        yield return new WaitForSeconds(2);

    }
    float CalculateHealth()
    {
        return playerHealthCurrent / playerHealthMax;
    }

}
