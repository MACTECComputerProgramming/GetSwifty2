using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterHealth : MonoBehaviour {


    public int playerHealthMax;
    public int playerHealthCurrent;
    public Slider healthBar;
    public Scene winScene;
    public Scene loseScene;


	
	void Start () {
        
        
    }



    // Update is called once per frame
    void Update() {
        

        if (playerHealthCurrent <= 0)
        {
            SceneManager.LoadScene(4);
        }
        if (transform.position.y < -20)
        {
            SceneManager.LoadScene(4);
        }
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            StartCoroutine(Damage());
            
        }
        if (collision.gameObject.tag.Equals("Flag"))
        {
            SceneManager.LoadScene(3);
        }

    }
    void OnTriggerExit(Collider other)
    {
        
    }

    IEnumerator Damage()
    {
        playerHealthCurrent -= 25;
        healthBar.value = CalculateHealth();
        yield return new WaitForSeconds(2);
        StopCoroutine(Damage());
    }
    float CalculateHealth()
    {
        return playerHealthCurrent;
    }

}
