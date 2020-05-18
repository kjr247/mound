using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject droppedThing;
    public float spawnRate = 2.0f;
    public float nextTime  = 0;
    private int maxDrops = 30;
  
    // Update is called once per frame
    void Update()
    {
        var rand = Random.Range( 0f, 1f);
        var randx = Random.Range( -10.0f, 10.0f);

        if (Time.time >= nextTime && maxDrops >= 0)
        {
            maxDrops--;
            Instantiate(droppedThing, new Vector3(randx, 10, 0), Quaternion.identity);
            nextTime += (spawnRate * rand);
        }
    }
}
