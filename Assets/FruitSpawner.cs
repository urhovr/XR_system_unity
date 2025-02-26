using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject fruitPrefab;
    public Transform spawnPoint;
    public float spawnRate = 1.0f;

    public void StartSpawning()
    {
        InvokeRepeating("SpawnFruit", 1.0f, spawnRate);
    }

    void SpawnFruit()
    {
        GameObject fruit = Instantiate(fruitPrefab, spawnPoint.position, Quaternion.identity);
        Rigidbody rb = fruit.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(Random.Range(-2f, 2f), Random.Range(5f, 8f), 0f);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
