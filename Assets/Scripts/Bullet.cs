using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;

    PlayerController playercontroller = new PlayerController();

	void Start () {
       
        rb.velocity = transform.right * speed;

        // used for game preformance destroying bullet after 1 second 
        InvokeRepeating("destroy", 1, 1);
    
	}

    void destroy()
    {
        // Destroys bullet after 1 second to avoid multiple objects being instatciated causing the game preformance to suffer
        Destroy(gameObject, 1);
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
       
        Debug.Log(collision.name);

        //Only destroy object that isnt the player, used to fix a bug where the bullet destroys the player 
        if(collision.name == "Player")
        {
            Debug.Log("self hit,dont destroy");
        }
        else
        {
            Destroy(gameObject);
        }

        if(enemy != null )
        {
            // + score by 10 each time player is hit!
            ScoreUpdate.scoreValue += 10;

            // Cause the enemy to take damage to enemy health
            enemy.TakeDamage(50);
            Destroy(gameObject);

        }

       
       
       

    }

    


}
