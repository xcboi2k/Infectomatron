using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCharacterScript : MonoBehaviour
{
    public GameObject NormalPerson, Doctor, Soldier, CharacterX;
    private const string selectedCharacter = "Selected Character";

    void Start()
    {
        int getCharacter = PlayerPrefs.GetInt(selectedCharacter);

        if (getCharacter == 1){
            CharacterX.SetActive(true);
        }

        else if (getCharacter == 2){
            NormalPerson.SetActive(true);
        }

        else if (getCharacter == 3){
            Soldier.SetActive(true);
        }
        
        else if (getCharacter == 4){
            Doctor.SetActive(true);
        }
    }
}