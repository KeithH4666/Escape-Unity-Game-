using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;

    PlayerController playercontroller = new PlayerController();

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
       
        Debug.Log(collision.name);

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
            enemy.TakeDamage(50);
            Destroy(gameObject);

        }

       
       
       

    }

    


}
