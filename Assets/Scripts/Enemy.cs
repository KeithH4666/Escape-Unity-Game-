using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public GameObject bullet;
    public GameObject Player;
    public Transform firePointEnemy;
   // public GameObject deathEffect;
    //public GameObject enemyThree;

    public float fireRate;
    public float nextFire;
    public int health = 100;
    // Use this for initialization

    public BoxCollider2D trigger;

    SpriteRenderer EnemyColor;


    private bool isPlayerNear = false;

	void Start () {

        fireRate = 2f;
        nextFire = Time.time;

        EnemyColor = GetComponent<SpriteRenderer>();

    }
	
	// Update is called once per frame
	void Update () {

     
        checkTimeFire();
        //checkPlayerToSpawnEnemy();
    
	}

    void OnTriggerEnter2D(Collider2D col)
    {

        if(col == trigger)
        {
            Debug.Log("Hit");

        }
    

    }


    void checkTimeFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bullet, firePointEnemy.position, firePointEnemy.rotation);
            nextFire = Time.time + fireRate;
        }
      
    }
    
    void checkPlayerToSpawnEnemy()
    {
        Debug.Log(Player.transform.position);
    }

 



 

    public void TakeDamage(int damage)
    {
        health -= damage;

        EnemyColor.color = new Color(255f, 0f, 0f, .3f);

        if (health <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
