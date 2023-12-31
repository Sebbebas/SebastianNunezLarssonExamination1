using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Transform[] spawnPos;
    [SerializeField] GameObject[] objects;
    
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 0.5f);
    }

    void SpawnEnemy()
    {
        Vector3 spawn = spawnPos[Random.Range(0, spawnPos.Length)].position;
        Instantiate(objects[Random.Range(0, objects.Length)], new(spawn.x, spawn.y), Quaternion.identity);
    }
}
