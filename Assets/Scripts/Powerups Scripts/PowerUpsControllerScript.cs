using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsControllerScript : MonoBehaviour
{
    public GameObject[] powerUps;
    int randomPowerUps;
    public Vector3 position;
    public static bool spawnAllowed;

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnAPowerUp", 2f, 5f); 
    }

    void Update()
    {
        
    }

    // Update is called once per frame
    void SpawnAPowerUp()
    {
        if (spawnAllowed){
            position = new Vector3(Random.Range(-19.25f, 19.25F), Random.Range(-8.75f, 8.75f));
            randomPowerUps = Random.Range(0, powerUps.Length);
            Instantiate (powerUps [randomPowerUps], position, Quaternion.identity);
        }
    }
}
