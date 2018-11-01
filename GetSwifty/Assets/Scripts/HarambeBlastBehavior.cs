using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarambeBlastBehavior : MonoBehaviour {

    public float blastSpeed;
    public Rigidbody2D rb;
    public GameObject blast;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * blastSpeed;
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(blast, 3);
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
