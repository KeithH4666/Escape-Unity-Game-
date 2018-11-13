using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject enemy;
    public GameObject spawnSpace;
    //public Transform EnemyBullet;

   

    private void Start()
    {
        enemy.SetActive(false);
        //EnemyBullet.GetComponent<SpriteRenderer>().enabled = false;
    }

    void OnTriggerEnter2D(Collider2D otherObject)
    {
        enemy.SetActive(true);
        spawnSpace.SetActive(false);
        //spawnSpace.GetComponent<BoxCollider2D>().enabled = false;
        Debug.Log(otherObject.name);
        //EnemyBullet.GetComponent<SpriteRenderer>().enabled = true;

    }
}
