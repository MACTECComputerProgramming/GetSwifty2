using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour {

    //Movement
    public Rigidbody2D enemyRb;
    NavMeshAgent nm;
    public float enemyRunSpeed;
    public Transform[] Waypoint;
    public int currentLocation;
   
    
    //Orientation
    private bool facingRight;

    
    



	// Use this for initialization
	void Start () {
        
        enemyRb = GetComponent<Rigidbody2D>();
        
        facingRight = true;
        currentLocation = 0;
	}
	
	// Update is called once per frame
	void Update () {
        
        

    }


    void FixedUpdate()
    {
        if (currentLocation == 0)
        {
            if (transform.position.x <= Waypoint[currentLocation].position.x)
            {
                currentLocation += 1;
            }
        }

        if (currentLocation == 1)
        {
            if (transform.position.x >= Waypoint[currentLocation].position.x)
            {
                currentLocation -= 1;
            }
        }





        //float horizontal = Input.GetAxis("Horizontal");

        Movement();
    }












    private void Movement()
    {
        if (currentLocation == 0)
        {
            enemyRb.velocity = new Vector2(-(enemyRunSpeed), enemyRb.velocity.y);
        }
        else
        {
            enemyRb.velocity = new Vector2(enemyRunSpeed, enemyRb.velocity.y);
        }
        //enemyRb.velocity = new Vector2(horizontal * enemyRunSpeed, enemyRb.velocity.y);
    }





}
