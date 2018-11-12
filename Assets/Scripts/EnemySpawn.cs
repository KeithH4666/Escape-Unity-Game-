using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject enemy;
    //public Transform EnemyBullet;

   

    private void Start()
    {
        enemy.SetActive(false);
        //EnemyBullet.GetComponent<SpriteRenderer>().enabled = false;
    }

    void OnTriggerEnter2D(Collider2D otherObject)
    {
        enemy.SetActive(true);
        Debug.Log(otherObject.name);
       
        //EnemyBullet.GetComponent<SpriteRenderer>().enabled = true;

    }
}
