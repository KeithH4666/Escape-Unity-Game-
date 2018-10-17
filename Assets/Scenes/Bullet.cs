using System.Collections;
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
       // Destroy(gameObject);
    }

}
