using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingManagerScript : MonoBehaviour
{
    public Slider loadingBar;
    float loadingTime;

    public GameObject continueButton, firstInstruction, secondInstruction;

    private const string loadsceneCommand = "Loading Scene Command";
    private const string selectedGameMode = "Game Mode";

    void Start(){
        loadingTime = 0f;
    }
    void Update()
    {
        loadingTime += Time.deltaTime;

        loadingBar.value = loadingTime;

        if(loadingTime >= 5f){
            firstInstruction.SetActive(false);
            secondInstruction.SetActive(true);
        }

        if(loadingTime >= 10f){
            secondInstruction.SetActive(false);
            continueButton.SetActive(true);
        }

        Debug.Log(loadingTime);
    }

    public void Continue(){
        int getCommand = PlayerPrefs.GetInt(loadsceneCommand);

        if(getCommand == 1){
            SceneManager.LoadScene("SelectModeScene");
        }

        else if(getCommand == 2){
            int getMode = PlayerPrefs.GetInt(selectedGameMode);

            if(getMode == 1){
                SceneManager.LoadScene("NormalGameplayScene");
            }
            else if (getMode == 2){
                SceneManager.LoadScene("ExtremeGameplayScene");
            }
            else if (getMode == 3){
                SceneManager.LoadScene("TimeAttackGameplayScene");
            }
            else if (getMode == 4){
                SceneManager.LoadScene("BossGameplayScene");
            }
        }
    }
}
