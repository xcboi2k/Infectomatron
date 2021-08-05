using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public AudioSource bulletAudioSource;
    public AudioClip enemyhitClip;

    void OnTriggerEnter2D(Collider2D target) {
      if(target.tag == "Enemy5"){
          GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().score += 5;
          GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().finalScore += 5;
          bulletAudioSource.PlayOneShot(enemyhitClip);

          Destroy(gameObject);
          Destroy(target.gameObject);
          Debug.Log("Killed an enemy");
      }

      if(target.tag == "Enemy10"){
          GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().score += 10;
          GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().finalScore += 10;
          bulletAudioSource.PlayOneShot(enemyhitClip);

          Destroy(gameObject);
          Destroy(target.gameObject);
          Debug.Log("Killed an enemy");
      }

      if(target.tag == "Enemy20"){
          GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().score += 20;
          GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().finalScore += 20;
          bulletAudioSource.PlayOneShot(enemyhitClip);
          
          Destroy(gameObject);
          Destroy(target.gameObject);
          Debug.Log("Killed an enemy");
      }

      if(target.tag == "Enemy Boss"){
          GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().score += 30;
          GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().finalScore += 30;
          GameObject.Find("Gameplay Controller").GetComponent<EnemyBossHealthScript>().currentHealth -= 30f;
          bulletAudioSource.PlayOneShot(enemyhitClip);
          
          Destroy(gameObject);
          Debug.Log("Damaged Enemy Boss");
      }  
    }
}
