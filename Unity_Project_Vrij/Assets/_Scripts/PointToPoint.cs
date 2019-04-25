using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToPoint : MonoBehaviour
{
    public List<Transform> SpawnPoints;
    public float spawnTime = 3f;            // How long between each spawn.
    public GameObject EnemyPrefab;

    public void NextPoint()
    {

    }

    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, SpawnPoints.Count);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(EnemyPrefab, SpawnPoints[spawnPointIndex].position, SpawnPoints[spawnPointIndex].rotation);
    }
}
