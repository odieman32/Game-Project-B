using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    //Code for Spawner
    [SerializeField] GameObject obstacle;
    [SerializeField] float maxX;
    [SerializeField] float maxY;
    [SerializeField] float minX;
    [SerializeField] float minY;
    [SerializeField] float timeBetweenSpawn;
    private float spawnTime;

    

    //Determines Spawn time of asteroids by input
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    //Spawns the asteroids at random based on the X and Y inputs
    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}

//Source: https://www.youtube.com/watch?v=U3sT-T5bKX4s by Hooson
