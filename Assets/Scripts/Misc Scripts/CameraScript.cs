using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Transform player;
    public float minX, maxX,minY, maxY;

    private const string selectedCharacter = "Selected Character";

    void Start()
    {
        int getCharacter = PlayerPrefs.GetInt(selectedCharacter);

        if (getCharacter == 1){
            player = GameObject.FindGameObjectWithTag("CharacterX").transform;
        }

        else if (getCharacter == 2){
            player = GameObject.FindGameObjectWithTag("Normal Person").transform;
        }

        else if (getCharacter == 3){
            player = GameObject.FindGameObjectWithTag("Soldier").transform;
        }
        
        else if (getCharacter == 4){
            player = GameObject.FindGameObjectWithTag("Doctor").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null){
            Vector3 temp = transform.position;
            temp.x = player.position.x;
            temp.y = player.position.y;
            transform.position = temp;

            if(temp.x < minX){
                temp.x = minX;
            }

            if (temp.x > maxX){
                temp.x = maxX;
            }

            if(temp.y < minY){
                temp.y = minY;
            }

            if (temp.y > maxY){
                temp.y = maxY;
            }

            
            transform.position = temp;
        }
    }
}
