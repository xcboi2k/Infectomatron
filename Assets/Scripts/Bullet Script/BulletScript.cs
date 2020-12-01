using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target) {
      if(target.tag == "Enemy5"){
          GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().score += 5;
          GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().finalScore += 5;
          Destroy(gameObject);
          Destroy(target.gameObject);
          Debug.Log("Killed an enemy");
      }

      if(target.tag == "Enemy10"){
          GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().score += 10;
          GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().finalScore += 10;
          Destroy(gameObject);
          Destroy(target.gameObject);
          Debug.Log("Killed an enemy");
      }

      if(target.tag == "Enemy20"){
          GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().score += 20;
          GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().finalScore += 20;
          Destroy(gameObject);
          Destroy(target.gameObject);
          Debug.Log("Killed an enemy");
      } 
    }
}
