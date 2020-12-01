using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    private Slider slider;

    private GameObject player;
    public float currentHealth = 100f;

    public bool isAlive = true;
    
    void Awake()
    {
        GetReferences();
    }

    void Update()
    {
        if(!player){
            return;
        }

        if(currentHealth > 0){
            slider.value = currentHealth;
            isAlive = true;
        }
        else{
            isAlive = false;
            GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().stopCountingScore = true;
        }
    }

    void GetReferences(){
        player = GameObject.Find("Player");
        slider = GameObject.Find("Health Bar").GetComponent<Slider>();

        slider.minValue = 0;
        slider.maxValue = currentHealth;
        slider.value = slider.maxValue;
    }
}
