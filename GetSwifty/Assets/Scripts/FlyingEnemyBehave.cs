using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemyBehave : MonoBehaviour {

    private CharacterContoller player;
    public float speed;
    public float playerRange;
    public LayerMask playerLayer;
    public bool playerInRange;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<CharacterContoller>();
	}
    //Kyler was here
    // Update is called once per frame
    void Update () 
    {
        playerInRange = Physics2D.OverlapCircle(transform.position, playerRange, playerLayer);

        if (playerInRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
	}

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawSphere(transform.position, playerRange);
    }

}
