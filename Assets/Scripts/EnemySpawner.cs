using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemySpawner : MonoBehaviour
{
    //voidaan kutsuu eri vihollisii
    public GameObject[] enemyPrefabs;
    // range for spawner[-xrange . . . xrange]
    public float xRange = 20.0f;
    public float zSpawn = 30f;

    private void SpwawnRandomOne()
    {
        // Create random integar
        int rnd = Random.Range(0, enemyPrefabs.Length);

        // Create random x-coord
        float xrnd = Random.Range(-xRange, xRange);

        Instantiate(enemyPrefabs[rnd], new Vector3(xrnd, 0f, zSpawn), enemyPrefabs[rnd].transform.rotation);

    }
    void Start()
    {
        InvokeRepeating("SpwawnRandomOne", 0f, 2.0f);

    }
    // Update is called once per frame
    void Update()
    {

    }
}
