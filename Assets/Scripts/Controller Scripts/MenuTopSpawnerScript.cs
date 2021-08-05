using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTopSpawnerScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] Virus;
    int randomSpawnPoint, randomVirus;
    public bool spawnAllowed;

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnAVirus", 0.2f, 0.5f);    
    }

    // Update is called once per frame
    void SpawnAVirus()
    {
        if (spawnAllowed){
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomVirus = Random.Range(0, Virus.Length);
            Instantiate (Virus[randomVirus], spawnPoints [randomSpawnPoint].position, Quaternion.identity);
        }
    }
}
