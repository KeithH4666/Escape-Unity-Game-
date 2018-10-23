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
        moveDirection = (player.transform.position - transform.position).normalized * Bulletspeed;
        //Enemyrb.velocity = transform.right * Bulletspeed;
        Enemyrb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        
        InvokeRepeating("destroy", 1, 1);

    }

    void destroy()
    {
        Destroy(gameObject, 1);
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
      
        PlayerController player = collision.GetComponent<PlayerController>();
        Debug.Log(collision.name);

        if (player != null)
        {
            player.TakeDamage(50);
        }

        Destroy(gameObject);

    }




}
