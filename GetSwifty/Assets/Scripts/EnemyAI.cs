using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour {

    //Movement
    private Rigidbody2D enemyRb;
    NavMeshAgent nm;
    public float enemyRunSpeed;
    public Transform[] Waypoint;
    public int currentLocation;
   
    
    //Orientation
    private bool facingRight;

    //Vector3(0, 0, 0);
    



	// Use this for initialization
	void Start () {
        
        enemyRb = GetComponent<Rigidbody2D>();
        
        facingRight = true;
        currentLocation = 0;
	}
	
	// Update is called once per frame
	void Update () {

        float distance = Vector2.Distance(transform.position, Waypoint[currentLocation].position);
        //Changing waypoints
        //Going to the waypoints
        if (currentLocation == 0)
        {
            
        }
        if (currentLocation == 1)
        {
            
        }

        if (distance <= 0.1)
        {
            if (currentLocation == 0)
            {
                currentLocation += 1;
            }
            else
            {
                currentLocation -= 1;
            }
        }

     /*   if (enemyRb.position != Waypoint[currentLocation].position)
        {

        }
        */



    }
}
