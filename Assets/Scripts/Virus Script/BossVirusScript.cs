using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossVirusScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target) {
      if(target.tag == "Normal Person"){
          GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth -= 20f;
          Destroy(gameObject);
          Debug.Log("Hit by projectile");
      }

      else if(target.tag == "Doctor"){
          GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth -= 5f;
          Destroy(gameObject);
          Debug.Log("Hit by projectile");
      }

      else if(target.tag == "Soldier"){
          GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth -= 13f;
          Destroy(gameObject);
          Debug.Log("Hit by projectile");
      }

      else if(target.tag == "CharacterX"){
          GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth -= 20f;
          Destroy(gameObject);
          Debug.Log("Hit by projectile");
      }
    }
}
