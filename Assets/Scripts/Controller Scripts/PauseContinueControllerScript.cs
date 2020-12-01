using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseContinueControllerScript : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenu;

    private const string selectedGameMode = "Game Mode";

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }

    void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void LoadMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenuScene");
    }

    public void Restart(){
        int getMode = PlayerPrefs.GetInt(selectedGameMode);
        if(getMode == 1){
            Time.timeScale = 1f;
            SceneManager.LoadScene("NormalGameplayScene");
        }
        
        else if(getMode == 2){
            Time.timeScale = 1f;
            SceneManager.LoadScene("ExtremeGameplayScene");
        }

    }
}
