using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBossHealthScript : MonoBehaviour
{
    private Slider slider;

    public float currentHealth = 5000f;

    public bool isAlive;

    public GameObject enemyBoss;

    void Awake() {
        GetReferences();
    }

    void Update() {
        if(currentHealth > 0){
            slider.value = currentHealth;
        }
        else{
            Destroy(enemyBoss);
            GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().isAlive = false;
            GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().stopCountingScore = true;
        }
    }

    void GetReferences(){
        slider = GameObject.Find("Enemy Health Bar").GetComponent<Slider>();

        slider.minValue = 0;
        slider.maxValue = currentHealth;
        slider.value = slider.maxValue;
    }
}
