using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterHealth : MonoBehaviour {


[SerializeField]
    private int playerHealthCurrent = 100;
    public Slider healthBar;
    public Scene winScene;
    public Scene loseScene;
    public Scene BossBattle;
    public Renderer rend;
    Color c;
    public int invincibilityTime;
    public bool invinc;

	
	void Start () {
        rend = GetComponent<Renderer>();
        c = rend.material.color;
        invinc = false;
        playerHealthCurrent = 100;
    }    
    void Update() {

        
        
        if (playerHealthCurrent <= 0)
        {
            SceneManager.LoadScene(4);
            ScoreScript.scoreValue = 0;
            Physics2D.IgnoreLayerCollision(9, 10, false);
        }
        if (transform.position.y < -20)
        {
            SceneManager.LoadScene(4);
            ScoreScript.scoreValue = 0;
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && invinc == false)
        {
            StartCoroutine(Damage());
            Physics2D.IgnoreLayerCollision(9, 10, true);
        }
        if (collision.gameObject.tag.Equals("Flag"))
        {
            SceneManager.LoadScene(5);
            
        }
        
        
    }
    IEnumerator Damage()
    {
        invinc = true;
        c.a = 0.5f;
        rend.material.color = c;
        Physics2D.IgnoreLayerCollision(9, 10, true);
        playerHealthCurrent -= 25;
        healthBar.value = CalculateHealth();
        yield return new WaitForSeconds(invincibilityTime);
        c.a = 1f;
        rend.material.color = c;
        invinc = false;
        Physics2D.IgnoreLayerCollision(9, 10, false);
        StopCoroutine(Damage());
    }
    public float CalculateHealth()
    {
        return playerHealthCurrent;
    }

}


