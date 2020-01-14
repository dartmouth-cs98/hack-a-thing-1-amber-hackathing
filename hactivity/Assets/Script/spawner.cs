using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float spawnRate = 1f;
    public GameObject hexagonPrefab;
    
    private float nextTimeToSpawn = 0f;

    // Update is called once per frame
    void Update()
    {
        //after nextTimeToSpawn has passed, create another hexagon at the center of the world w/ no rotation
        if (Time.time >= nextTimeToSpawn)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
        
    }
}
