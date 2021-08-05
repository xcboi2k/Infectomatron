using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectModeControllerScript : MonoBehaviour
{
    public Text normalHighScoreText, extremeHighScoreText, timeAttackHighScoreText, bossHighScoreText;

    public GameObject scoreBoard;

    private const string selectedGameMode = "Game Mode";
    private const string loadsceneCommand = "Loading Scene Command";

    private const string normalHighScore = "Normal High Score";
    private const string extremeHighScore = "Extreme High Score";
    private const string timeAttackHighScore = "Time Attack High Score";
    private const string bossHighScore = "Boss High Score";

    void Awake(){
        int normalHS = PlayerPrefs.GetInt(normalHighScore);
        int extremeHS = PlayerPrefs.GetInt(extremeHighScore);
        int timeAttackHS = PlayerPrefs.GetInt(timeAttackHighScore);
        int bossHS = PlayerPrefs.GetInt(bossHighScore);

        normalHighScoreText.text = "" + normalHS;
        extremeHighScoreText.text = "" + extremeHS;
        timeAttackHighScoreText.text = "" + timeAttackHS;
        bossHighScoreText.text = "" + bossHS;
    }

    public void SelectedNormalMode(){
        PlayerPrefs.SetInt(selectedGameMode, 1);
        PlayerPrefs.SetInt(loadsceneCommand, 2);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectedExtremeMode(){
        PlayerPrefs.SetInt(selectedGameMode, 2);
        PlayerPrefs.SetInt(loadsceneCommand, 2);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectedTimeAttackMode(){
        PlayerPrefs.SetInt(selectedGameMode, 3);
        PlayerPrefs.SetInt(loadsceneCommand, 2);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectedBossMode(){
        PlayerPrefs.SetInt(selectedGameMode, 4);
        PlayerPrefs.SetInt(loadsceneCommand, 2);
        SceneManager.LoadScene("LoadingScene");
    }

    public void ShowScoreboard(){
        scoreBoard.SetActive(true);
    }

    public void CloseScoreboard(){
        scoreBoard.SetActive(false);
    }
}
