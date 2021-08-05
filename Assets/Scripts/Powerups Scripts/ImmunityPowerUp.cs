using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImmunityPowerUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target) {
      if(target.tag == "Normal Person"){
        GameObject.FindGameObjectWithTag("Normal Person").GetComponent<NormalPersonScript>().isImmune = true;
        Destroy(gameObject);
        Debug.Log("Immunity activated.");
      }

      else if(target.tag == "Doctor"){
        GameObject.FindGameObjectWithTag("Doctor").GetComponent<DoctorScript>().isImmune = true;
        Destroy(gameObject);
        Debug.Log("Immunity activated.");
      }  

      else if(target.tag == "Soldier"){
        GameObject.FindGameObjectWithTag("Soldier").GetComponent<SoldierScript>().isImmune = true;
        Destroy(gameObject);
        Debug.Log("Immunity activated.");
      }

      else if(target.tag == "CharacterX"){
        GameObject.FindGameObjectWithTag("CharacterX").GetComponent<PlayerScript>().isImmune = true;
        Destroy(gameObject);
        Debug.Log("Immunity activated.");
      }  
    }
}
