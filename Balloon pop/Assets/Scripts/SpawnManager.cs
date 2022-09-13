using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPreFabs; // array to store balloon game object
    public float startDelay = 0.5f;
    public float spawnInterval = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void SpawnRandomBalloon()
    {
        // Get a random position on the x-axis
        Vector3 spawnPos = new Vector3(Random.Range(-5, 5), 10, 0);

        // pick a random balloon from the balloon array
        int balloonIndex = Random.Range(0,balloonPreFabs.Length);

        // Spawn random balloon at spawn position
        Instantiate(balloonPreFabs[balloonIndex], spawnPos, balloonPreFabs[balloonIndex].transform.rotation);
    }
}
