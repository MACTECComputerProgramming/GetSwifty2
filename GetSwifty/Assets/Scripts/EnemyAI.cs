using UnityEngine;


public class EnemyAI : MonoBehaviour {

    //Movement
    public Rigidbody2D enemyRb;
    public float enemyRunSpeed;
    public Transform[] Waypoint;
    public int currentLocation;
   
    
	// Use this for initialization
	void Start () {
        enemyRb = GetComponent<Rigidbody2D>();
        currentLocation = 0;
	}

    void Update()
    {
        if (transform.position.y <= -150)
        {
            Destroy(gameObject);
        }




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

        Movement();
        Flip();

    }

    
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
