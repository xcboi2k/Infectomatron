using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target) {
      if(target.tag == "Player"){
          GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth -= 2f;
          Destroy(gameObject);
          Debug.Log("Hit by projectile");
      }
    }
}
