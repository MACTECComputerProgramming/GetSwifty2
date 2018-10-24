using UnityEngine;


public class EnemyAI : MonoBehaviour {

    
    public Rigidbody2D enemyRb; //Enemy rigidbody to be manipulated
    public float enemyRunSpeed; //Enemy's runspeed (force to be added to rigidbody)
    public Transform[] Waypoint; //Group of empties to be used as waypoints
    public int currentLocation; //Index of current waypoint
   
	//Detects current rigidbody and sets the current location to zero
	void Start ()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        currentLocation = 0;
	}

    //Detects every frame if the enemy is below the platform and destroys if true
    void Update()
    {
        if (transform.position.y <= -20)
        {
            Destroy(gameObject);
        }
    }

    //Detects the current location and switches if the empty has been passed
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

        //Calles the movement and flip methods
        Movement();
        Flip();
    }

    //Adds force to the enemy rigidbody to move it to the current waypoint
    private void Movement()
    {
        if (currentLocation == 0)
        {
            enemyRb.velocity = new Vector2(-2 * (enemyRunSpeed), enemyRb.velocity.y);
        }
        else if(currentLocation == 1)
        {
            enemyRb.velocity = new Vector2(2 * enemyRunSpeed, enemyRb.velocity.y);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    //Kyler was here
    //Flips the enemy if needed
    private void Flip()
    {

        if (currentLocation == 0 && transform.localScale.x > 0)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
        if (currentLocation == 1 && transform.localScale.x < 0)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }









}
