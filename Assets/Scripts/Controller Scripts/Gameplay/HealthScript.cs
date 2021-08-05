using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    private GameObject player;
    public GameObject NormalPerson, Doctor, Soldier, CharacterX;
    public float currentHealth = 100f;

    public bool isAlive;

    private const string selectedCharacter = "Selected Character";
    
    void Awake()
    {
        isAlive = true;
        GetReferences();
    }

    void Update()
    {
        if(!player){
            return;
        }

        if(currentHealth > 0){
            slider.value = currentHealth;
            fill.color = gradient.Evaluate(slider.normalizedValue);
            isAlive = true;
        }
        else{
            isAlive = false;
            GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().stopCountingScore = true;
        }
    }

    void GetReferences(){
        int getCharacter = PlayerPrefs.GetInt(selectedCharacter);

        if (getCharacter == 1){
            player = NormalPerson;
        }

        else if (getCharacter == 2){
            player = Doctor;
        }

        else if (getCharacter == 3){
            player = Soldier;
        }

        else if (getCharacter == 4){
            player = CharacterX;
        }

        slider = GameObject.Find("Health Bar").GetComponent<Slider>();

        slider.minValue = 0;
        slider.maxValue = currentHealth;
        slider.value = slider.maxValue;
        fill.color = gradient.Evaluate(1f);
    }
}
