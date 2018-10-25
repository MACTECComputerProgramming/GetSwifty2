using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemyBehave : MonoBehaviour {

    private CharacterContoller player;
    public float speed;
    public float playerRange;
    public LayerMask playerLayer;
    public bool playerInRange;
    public int flyingHeight;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<CharacterContoller>();
	}
    
    // Update is called once per frame
    void Update () 
    {

        //if the player is in the circle the moth will follow
        playerInRange = Physics2D.OverlapCircle(transform.position, playerRange, playerLayer);

        if (playerInRange)
        {
            transform.position = Vector3.MoveTowards(transform.position , player.transform.position, speed * Time.deltaTime);
        }
	}

    void OnDrawGizmosSelected()
    {
        
        Gizmos.DrawSphere(transform.position, playerRange);
    }

}
