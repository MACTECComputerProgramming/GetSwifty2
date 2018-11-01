using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Sounds : MonoBehaviour {

    public AudioClip fire;
    public AudioClip jump;
    public AudioClip hurt;
    public AudioClip banana;
    private AudioSource source;


	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            source.PlayOneShot(jump);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            source.PlayOneShot(fire);
        }


	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            source.PlayOneShot(hurt);
        }
        if (other.gameObject.tag == "Banana")
        {
            source.PlayOneShot(banana);
        }
    }



}
