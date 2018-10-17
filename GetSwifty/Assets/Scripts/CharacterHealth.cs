using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour {

    public int playerHealth;
    
	
	void Start () {
        playerHealth = 100;
        
    }
	
	// Update is called once per frame
	void Update() {
        if (playerHealth <= 0)
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
        playerHealth -= 25;
        yield return new WaitForSeconds(2);

    }


}
