using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFiveProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D target) {
      if(target.tag == "Player"){
          //TakeDamage(5.0f);
          Destroy(target.gameObject);
          Debug.Log("Player received damage");
      }  
    }

    //void TakeDamage(float damage){
        //currentHealth -= damage;

        //healthBar.SetHealth(currentHealth);
    //}
}
