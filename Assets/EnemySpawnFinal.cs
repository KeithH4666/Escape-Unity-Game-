using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnFinal : MonoBehaviour
{

    public GameObject enemy;
    public GameObject spawnSpace;

    public GameObject enemy2;
   
    //public Transform EnemyBullet;



    private void Start()
    {
        enemy.SetActive(false);
        enemy2.SetActive(false);
        //EnemyBullet.GetComponent<SpriteRenderer>().enabled = false;
    }

    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.name == "Player")
        {
            enemy.SetActive(true);
            spawnSpace.SetActive(false);

            enemy2.SetActive(true);
            //spawnSpace2.SetActive(false);
            //spawnSpace.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log(otherObject.name);
            //EnemyBullet.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
