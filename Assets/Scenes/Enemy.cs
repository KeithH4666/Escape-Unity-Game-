using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public GameObject bullet;
    public float fireRate;
    public float nextFire;
	// Use this for initialization
	void Start () {
        fireRate = 1f;
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
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
      
    }
}
