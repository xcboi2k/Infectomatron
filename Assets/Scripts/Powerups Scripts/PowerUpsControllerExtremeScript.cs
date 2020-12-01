using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsControllerExtremeScript : MonoBehaviour
{
    public GameObject[] powerUps;
    int randomPowerUps;
    public Vector3 position;
    public static bool spawnAllowed;

    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnAPowerUp", 5f, 7f); 
    }

    void SpawnAPowerUp()
    {
        if (spawnAllowed){
            position = new Vector3(Random.Range(-19.25f, 19.25F), Random.Range(-8.75f, 8.75f));
            randomPowerUps = Random.Range(0, powerUps.Length);
            Instantiate (powerUps [randomPowerUps], position, Quaternion.identity);
        }
    }
}
