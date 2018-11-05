using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject player; //Object the camera will follow
    private Vector3 offset; //Camera's location in relation to the player


    //Initializes the camera's position based on editor position and player position
    void Start ()
    {
        offset = transform.position - player.transform.position;
	}

    
    //Resets the camera's location variable and sets its location to the new variable
    void LateUpdate ()
    {
        offset.Set(player.transform.position.x, 1, transform.position.z - player.transform.position.z);
        transform.position = offset;
	}
}
