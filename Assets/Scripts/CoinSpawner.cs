﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public float timeBetweenSpawns;
    public GameObject prefab;  // pass in to script

    private float timeToNextSpawn;

    // Start is called before the first frame update
    void Start()
    {
        timeToNextSpawn = timeBetweenSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
