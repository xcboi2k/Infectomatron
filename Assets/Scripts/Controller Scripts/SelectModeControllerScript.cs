using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectModeControllerScript : MonoBehaviour
{
    public Text normalHighScoreText, extremeHighScoreText;

    private const string selectedGameMode = "Game Mode";
    private const string normalHighScore = "Normal High Score";
    private const string extremeHighScore = "Extreme High Score";

    void Awake(){
        int normalHS = PlayerPrefs.GetInt(normalHighScore);
        int extremeHS = PlayerPrefs.GetInt(extremeHighScore);

        normalHighScoreText.text = "" + normalHS;
        extremeHighScoreText.text = "" + extremeHS;
    }

    public void SelectedNormalMode(){
        PlayerPrefs.SetInt(selectedGameMode, 1);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectedExtremeMode(){
        PlayerPrefs.SetInt(selectedGameMode, 2);
        SceneManager.LoadScene("LoadingScene");
    }
}
