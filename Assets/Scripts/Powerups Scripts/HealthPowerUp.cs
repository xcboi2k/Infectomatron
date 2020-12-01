using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D target) {
      if(target.tag == "Player"){
          Destroy(gameObject);
          Debug.Log("Increase Health");

          if(GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth < 100f){
              GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth += 20f;
          }
      }  
    }
}
