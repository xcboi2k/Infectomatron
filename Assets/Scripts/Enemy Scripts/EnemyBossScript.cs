using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossScript : MonoBehaviour
{
    public float speed;
    private Transform target;
    public float stoppingDistance;

    public GameObject projectileHolder;
    public GameObject projectile;
    public int numberOfProjectiles;

    private float launchTime = 2.0f;
    float radius, moveSpeed;

    private const string selectedCharacter = "Selected Character";

    public GameObject characterX, normalPerson, soldier, doctor;

    void Start() {
        int getCharacter = PlayerPrefs.GetInt(selectedCharacter);

        if (getCharacter == 1){
            target = characterX.GetComponent<Transform>();
        }

        else if (getCharacter == 2){
            target = normalPerson.GetComponent<Transform>();
        }

        else if (getCharacter == 3){
            target = soldier.GetComponent<Transform>();
        }

        else if (getCharacter == 4){
            target = doctor.GetComponent<Transform>();
        }

        radius = 5f;
        moveSpeed = 5f;
    }

    void Update()
    {
        bool approachTarget = GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().isAlive;
        if(approachTarget == true){
            if(Vector2.Distance(transform.position, target.position) > stoppingDistance){
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }

            launchTime -= Time.deltaTime;

            if(launchTime <= 0.0f){
                LaunchProjectiles(numberOfProjectiles);
                launchTime = 2.0f;
            }
        }
        else{
            GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().isAlive = false;
            GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().stopCountingScore = true;
        }
    }

    void LaunchProjectiles(int numberOfProjectiles){
        float angleStep = 360f / numberOfProjectiles;
        float angle = 0f;

        for(int i = 0; i <= numberOfProjectiles - 1; i++){
            float projectileDirXposition = projectileHolder.transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180) * radius;
            float projectileDirYposition = projectileHolder.transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180) * radius;

            Vector2 projectileVector = new Vector2(projectileDirXposition, projectileDirYposition);
            Vector2 projectileHolderPos = projectileHolder.transform.position;
            Vector2 projectileMoveDirection = (projectileVector - projectileHolderPos).normalized * moveSpeed;

            var proj = Instantiate(projectile, projectileHolder.transform.position, Quaternion.identity);
            proj.GetComponent<Rigidbody2D>().velocity = new Vector2 (projectileMoveDirection.x, projectileMoveDirection.y);
            angle += angleStep;
        }
    }
}
