﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;

	void Start () {
        rb.velocity = transform.right * speed;
        InvokeRepeating("destroy", 1, 1);
    
	}

    void destroy()
    {
        Destroy(gameObject, 1);
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        PlayerController player = collision.GetComponent<PlayerController>();
        Debug.Log(collision.name);

        if(enemy != null)
        {
            enemy.TakeDamage(50);
        }
        if (player != null)
        {
            player.TakeDamage(50);
        }
        //Destroy(gameObject);

    }

    


}