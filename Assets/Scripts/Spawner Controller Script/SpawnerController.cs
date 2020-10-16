using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] viruses;
    int randomSpawnPoint, randomVirus;
    public static bool spawnAllowed;

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnAVirus", 0f, 1f);    
    }

    // Update is called once per frame
    void SpawnAVirus()
    {
        if (spawnAllowed){
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomVirus = Random.Range(0, viruses.Length);
            Instantiate (viruses [randomVirus], spawnPoints [randomSpawnPoint].position, Quaternion.identity);
        }
    }
}
