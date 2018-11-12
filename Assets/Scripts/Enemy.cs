using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public GameObject bullet;
    public Transform firePointEnemy;
    public GameObject deathEffect;
    //public GameObject enemyThree;

    public float fireRate;
    public float nextFire;
    public int health = 100;
	// Use this for initialization
	void Start () {

        fireRate = 2f;
        nextFire = Time.time;
       
    }
	
	// Update is called once per frame
	void Update () {
        checkTimeFire();
	}

    void checkTimeFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bullet, firePointEnemy.position, firePointEnemy.rotation);
            nextFire = Time.time + fireRate;
        }
      
    }

   

    public void TakeDamage(int damage)
    {
        health -= damage;


        if(health <= 0)
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
