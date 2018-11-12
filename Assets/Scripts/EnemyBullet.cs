using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    public float Bulletspeed = 10f;
    public Rigidbody2D Enemyrb;

    PlayerController player;
    Vector2 moveDirection;



    void Start()
    {
        Enemyrb = GetComponent<Rigidbody2D>();
        player = GameObject.FindObjectOfType<PlayerController>();
        moveDirection = (player.player.transform.position - transform.position).normalized * Bulletspeed;
        Debug.Log("player" + player.transform.position);
        //Enemyrb.velocity = transform.right * Bulletspeed;
        Enemyrb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        
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
      
        PlayerController player = collision.GetComponent<PlayerController>();
        Debug.Log(collision.name);

        if (player != null)
        {
            // Update score -5 each time player gets hit
            ScoreUpdate.scoreValue -= 5;

            // Update player health
            player.TakeDamage(50);
        }

        // Destroy Bullet
        Destroy(gameObject);

    }




}
