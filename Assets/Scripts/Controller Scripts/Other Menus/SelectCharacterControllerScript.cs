using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectCharacterControllerScript : MonoBehaviour
{
    public Text thirdCharacterText, fourthCharacterText;
    public GameObject lockedPanel3, lockedPanel4;
    public GameObject characterButton3, characterButton4;

    private const string selectedCharacter = "Selected Character";
    private const string loadsceneCommand = "Loading Scene Command";

    void Start(){
        thirdCharacterText.text = "Locked";
        fourthCharacterText.text = "Locked";

        characterButton3.SetActive(false);
        characterButton4.SetActive(false);
    }
    public void SelectCharacterX(){
        PlayerPrefs.SetInt(selectedCharacter, 1);
        PlayerPrefs.SetInt(loadsceneCommand, 1);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectNormalPerson(){
        PlayerPrefs.SetInt(selectedCharacter, 2);
        PlayerPrefs.SetInt(loadsceneCommand, 1);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectSoldier(){
        PlayerPrefs.SetInt(selectedCharacter, 3);
        PlayerPrefs.SetInt(loadsceneCommand, 1);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectDoctor(){
        PlayerPrefs.SetInt(selectedCharacter, 4);
        PlayerPrefs.SetInt(loadsceneCommand, 1);
        SceneManager.LoadScene("LoadingScene");
    }
}
