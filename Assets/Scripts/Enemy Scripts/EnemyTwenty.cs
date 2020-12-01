using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwenty : MonoBehaviour
{
    public float speed;
    private Transform target;
    public float stoppingDistance;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update() {
        bool approachTarget = GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().isAlive;
        if(approachTarget == true){
            if(Vector2.Distance(transform.position, target.position) > stoppingDistance){
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
        }
    }
}
