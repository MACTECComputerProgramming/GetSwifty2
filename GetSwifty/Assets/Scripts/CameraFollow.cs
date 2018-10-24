using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    //Object the camera will follow
    public GameObject player;
    //Camera's location in relation to the player
    private Vector3 offset;

	//Initializes the camera's position based on editor position and player position
	void Start () {
        offset = transform.position - player.transform.position;
	}

    //Kyler was here
    //Resets the camera's location variable and sets its location to the new variable
    void LateUpdate () {
        offset.Set(player.transform.position.x, 1, transform.position.z - player.transform.position.z);
        transform.position = offset;
	}
}
