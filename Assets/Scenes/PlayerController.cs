using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 10.0f;
    public bool facingRight = true;
    public bool facingUp = true;
    public bool facingLeft = true;
    public bool facingDown = true;
    Vector2 AxisInput;

    Transform player;

    Rigidbody2D body;
    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;
    public float runSpeed = 10;


    
	void Start () {
        //player = GameObject.Find("Player").GetComponent<Transform>();
        //transform.Rotate(Vector3.up * 90);

        body = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }


    void flip()
    {
        facingRight = !facingRight;
        
        transform.Rotate(0f,180f,0f);
        //FixedUpdate();
    }
    void flip2()
    {
        facingUp = !facingUp;
        
        
        transform.Rotate(180f, 0f, 0f);
        //FixedUpdate();
    }


    void FixedUpdate () {

        if (horizontal != 0 && vertical != 0)
        {
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
        if (vertical < 0 && facingUp)
        {
            flip2();
        }
        if (vertical > 0 && !facingUp)
        {
            flip2();
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
