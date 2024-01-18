using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject myBubble;

    public void SpawnBubble()
    {
        int spawnPointX = Random.Range(-3, 10);
        int spawnPointY = Random.Range(-6, -7);
        int spawnPointZ = 1;

        Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointZ); 

        Instantiate(myBubble, spawnPosition, Quaternion.identity);
    }
}
