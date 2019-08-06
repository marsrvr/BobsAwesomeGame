using System.Collections;
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

    void Spawn()
    {
        for (float i = 0; i<50; i++)
        {
            Instantiate(prefab, new Vector2(-50.0f + 2f*i,12),Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Running at fps (usually 60)
        timeToNextSpawn -= Time.deltaTime;
        if (timeToNextSpawn <= 0.0f)
        {
            Spawn();
            timeToNextSpawn = timeBetweenSpawns;
        }
    }
}
