﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private int spawnInterval;

    // Start is called before the first frame update
    private void Update()
    {

    }
    void Start()
    {
        spawnInterval = Random.Range(3, 5);

        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int spawnBall = Random.Range(0, 2);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[spawnBall], spawnPos, ballPrefabs[spawnBall].transform.rotation);
    }

}
