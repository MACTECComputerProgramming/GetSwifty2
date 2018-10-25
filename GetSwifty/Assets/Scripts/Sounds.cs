using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Sounds : MonoBehaviour {

    public AudioClip jump;
    public AudioClip hurt;
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

	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            source.PlayOneShot(hurt);
        }
    }



}
