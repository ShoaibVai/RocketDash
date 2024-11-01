using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab1;
    public GameObject obstaclePrefab2;
    public GameObject obstaclePrefab3;
    public float spawnRate = 2f; // Adjust this in the inspector

    private float nextSpawnTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObstacle();
            nextSpawnTime = Time.time + 1f / spawnRate;
        }
    }

    void SpawnObstacle()
    {
        // Randomly choose which prefab to spawn
        int randomIndex = Random.Range(1, 4);
        GameObject obstaclePrefab;

        switch (randomIndex)
        {
            case 1:
                obstaclePrefab = obstaclePrefab1;
                break;
            case 2:
                obstaclePrefab = obstaclePrefab2;
                break;
            case 3:
                obstaclePrefab = obstaclePrefab3;
                break;
            default:
                obstaclePrefab = obstaclePrefab1; // Default to the first prefab
                break;
        }

        // Randomly generate position on x and y axes
        float randomX = Random.Range(210f, 1750f);
        float randomY = Random.Range(1400f, 1750f);
        Vector3 randomPosition = new Vector3(randomX, randomY, transform.position.z);

        // Spawn the obstacle
        Instantiate(obstaclePrefab, randomPosition, Quaternion.identity);
    }
}
