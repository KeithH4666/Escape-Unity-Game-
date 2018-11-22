using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float speed = 10.0f;
    public bool facingRight = true;
    public bool facingUp = true;
    public bool facingLeft = true;
    public bool facingDown = true;
    //public int playerHealth = 100;
    Vector2 AxisInput;

    public Transform player;
    public Transform firePoint;
    //public Transform firePoint;

    Rigidbody2D body;
    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;
    public float runSpeed = 10;

    //Joystick 
    private bool touch = false;
    private Vector2 pointA;
    private Vector2 pointB;
    public Vector2 offset;
    public Vector2 direction;

    public Transform circle;
    public Transform outerCircle;



    void Start () {
        //player = GameObject.Find("Player").GetComponent<Transform>();
        //transform.Rotate(Vector3.up * 90);

        //body = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        
        //horizontal = Input.GetAxisRaw("Horizontal");
       // vertical = Input.GetAxisRaw("Vertical");

        //Debug.Log(horizontal);


        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("touch");
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,Camera.main.transform.position.z));

            circle.transform.position = pointA * -1;
            outerCircle.transform.position = pointA * -1;
            //circle.GetComponent<SpriteRenderer>().enabled = true;
            //outerCircle.GetComponent<SpriteRenderer>().enabled = true;

        }
        if (Input.GetMouseButton(0))
        {
            touch = true;
                //Debug.Log("touch");
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }
        else
        {
            touch = false;
        }
    }

    void MoveChar(Vector2 direction)
    {
        player.Translate(direction * speed * Time.deltaTime);
       // Debug.Log("players position" + player.position);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("player hit" + collision.name);

    }


        public void TakeDamage(int damage)
    {
        // playerHealth -= damage;
        ScoreUpdate.health -= 50;

        if (ScoreUpdate.health <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        
        //Temporary end game 
        SceneManager.LoadScene("Menu");
    }


    void flip()
    {
        facingRight = !facingRight;
        
        firePoint.transform.Rotate(0f,180f,0f);
        //FixedUpdate();
    }



    void FixedUpdate () {

        //Debug.Log(horizontal);
        /*
        if (horizontal < 0 && facingRight)
        {
            flip();
        }
        if (horizontal > 0 && !facingRight)
        {
            flip();
        }
        */

        if (touch)
        {
            offset = pointB - pointA;
            direction = Vector2.ClampMagnitude(offset, 1.0f);
            MoveChar(direction*-1);

            circle.transform.position = new Vector2(pointA.x + direction.x, pointA.y + direction.y) * -1;

            //Debug.Log(offset);

            // Using x and y offset  to determine which direction the player is facing, needed to get which direction the  bullet is going
            if(offset.x > 0.0 && facingRight)
            {
                flip();
            }
            if(offset.x < 0.0 && !facingRight)
            {
                flip();
            }
            /*
            if (horizontal != 0 && vertical != 0)
            {
                Vector2 offset = pointB - pointA;
                body.velocity = new Vector2((horizontal * runSpeed) * moveLimiter, (vertical * runSpeed) * moveLimiter);

            }
            else
            {
                body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);

            }

        

            if (horizontal < 0 && facingRight)
            {
                flip();
            }
            if (horizontal > 0 && !facingRight)
            {
                flip();
            }
            */


        }
        else
        {

            circle.GetComponent<SpriteRenderer>().enabled = false;
            outerCircle.GetComponent<SpriteRenderer>().enabled = false;

        }
        



        //Rigidbody2D.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed;

        /*

        Vector3 movement = Vector3.zero;
        
        
        if (Input.GetKey(KeyCode.W))
        {
            movement = Vector3.up * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement = -Vector3.up * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement = Vector3.right * speed;
          
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement = -Vector3.right * speed;
           
          
        }

        
        */

        //Debug.Log(movement);
        /*
        if(movement.x == 0)
        {
            movement.x = 0;
        }
        */


        // player.Translate(movement);


    }
}
