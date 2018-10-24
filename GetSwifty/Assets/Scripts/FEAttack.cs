using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FEAttack : MonoBehaviour {
    //public Transform firePoint;
    public GameObject Bullet;
    public float playerRange;
    public CharacterContoller player;
    public Transform launchPoint;
    public float waitBetweenShots;
    private float shotCounter;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<CharacterContoller>();

        shotCounter = waitBetweenShots;

	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawLine  (new Vector3(transform.position.x - playerRange, transform.position.y, transform.position.z),new Vector3 (transform.position.x + playerRange, transform.position.y, transform.position.z));

        shotCounter -= Time.deltaTime;

        if (/*transform.localScale.y < 0 &&*/ transform.position.x == player.transform.position.x && shotCounter < 0)
        {
            Instantiate(Bullet, launchPoint.position, launchPoint.rotation);
            shotCounter = waitBetweenShots;
        }
<<<<<<< HEAD

        if (/*transform.localScale.y > 0 &&*/ transform.position.x == player.transform.position.x && shotCounter < 0)
        {
            Instantiate(Bullet, launchPoint.position, launchPoint.rotation);
            shotCounter = waitBetweenShots;
        } 

	}
=======
        //Kyler was here
    }
>>>>>>> a985859b094f6c06d70b782666ed1f90ce50d0f1

   
}
