using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D target) {
      if(target.tag == "Enemy"){
          Destroy(gameObject);
          Destroy(target.gameObject);
          Debug.Log("Killed an enemy");
      }  
    }
}
