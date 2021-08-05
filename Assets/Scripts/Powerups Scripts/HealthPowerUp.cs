using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target) {
      if(target.tag == "Normal Person"){
          //GameObject.FindGameObjectWithTag("Normal Person").GetComponent<NormalPersonScript>().healthPicked = true;
          Destroy(gameObject);
          Debug.Log("Increase Health");

          if(GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth < 100f){
              GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth += 20f;
          }
      }

      else if(target.tag == "Doctor"){
          //GameObject.FindGameObjectWithTag("Doctor").GetComponent<DoctorScript>().healthPicked = true;
          Destroy(gameObject);
          Debug.Log("Increase Health");

          if(GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth < 100f){
              GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth += 20f;
          }
      } 

      else if(target.tag == "Soldier"){
          //GameObject.FindGameObjectWithTag("Soldier").GetComponent<SoldierScript>().healthPicked = true;
          Destroy(gameObject);
          Debug.Log("Increase Health");

          if(GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth < 100f){
              GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth += 20f;
          }
      }

      else if(target.tag == "CharacterX"){
          //GameObject.FindGameObjectWithTag("CharacterX").GetComponent<PlayerScript>().healthPicked = true;
          Destroy(gameObject);
          Debug.Log("Increase Health");

          if(GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth < 100f){
              GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth += 20f;
          }
      }  
    }
}
