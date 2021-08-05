using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControllerScript : MonoBehaviour
{

    public GameObject creditsPanel;

    public void PlayGame(){
        SceneManager.LoadScene("SelectCharacterScene");
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void OpenCredits(){
        creditsPanel.SetActive(true);
    }

    public void ExitCredits(){
        creditsPanel.SetActive(false);
    }
}
