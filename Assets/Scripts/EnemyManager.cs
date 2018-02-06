using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public Hero hero;       // Reference to the player's heatlh.
    public GameObject nurse;                // The enemy prefab to be spawned.
    public float spawnTime = 1f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.

    // Use this for initialization
    void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        hero = FindObjectOfType<Hero>();
    }

    void Spawn()
    {
        // If the player has no health left...  Not necessary yet
        if (hero.hp <= 0f)
        {
            // ... exit the function.
            return;
        }


        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(nurse, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

        // Create another instance of the enemy prefab on another random spawn point
        Instantiate(nurse, spawnPoints[Random.Range(0,spawnPointIndex)].position, spawnPoints[spawnPointIndex].rotation);
        
    }
}
