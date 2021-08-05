using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTen : MonoBehaviour
{
    public float speed;
    private Transform target;
    public float stoppingDistance;

    private const string selectedCharacter = "Selected Character";


    void Start()
    {
        int getCharacter = PlayerPrefs.GetInt(selectedCharacter);

        if (getCharacter == 1){
            target = GameObject.FindGameObjectWithTag("CharacterX").GetComponent<Transform>();
        }

        else if (getCharacter == 2){
            target = GameObject.FindGameObjectWithTag("Normal Person").GetComponent<Transform>();
        }

        else if (getCharacter == 3){
            target = GameObject.FindGameObjectWithTag("Soldier").GetComponent<Transform>();
        }

        else if (getCharacter == 4){
            target = GameObject.FindGameObjectWithTag("Doctor").GetComponent<Transform>();
        }
    }

    void Update() {
        bool approachTarget = GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().isAlive;
        if(approachTarget == true){
            if(Vector2.Distance(transform.position, target.position) > stoppingDistance){
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
        }
        else{
            Destroy(gameObject);
        }
    }
}
