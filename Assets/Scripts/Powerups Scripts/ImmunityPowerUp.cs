using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImmunityPowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D target) {
      if(target.tag == "Player"){
        GameObject.Find("Player").GetComponent<PlayerScript>().isImmune = true;
        Destroy(gameObject);
        Debug.Log("Immunity activated.");
      }  
    }
}
