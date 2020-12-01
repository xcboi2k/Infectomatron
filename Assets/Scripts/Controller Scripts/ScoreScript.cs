using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText, finalScoreText;

    public int score, finalScore;

    public bool stopCountingScore;

    private const string selectedGameMode = "Game Mode";
    private const string normalHighScore = "Normal High Score";
    private const string extremeHighScore = "Extreme High Score";

    void Start() {
        stopCountingScore = false;
    }
    void Update(){
        if(stopCountingScore == false){
            scoreText.text = "" + score;
        }

        else{
            finalScoreText.text = "" + finalScore;
            int getMode = PlayerPrefs.GetInt(selectedGameMode);
            if(getMode == 1){
                int getScore = PlayerPrefs.GetInt(normalHighScore);
                if(finalScore > getScore){
                    PlayerPrefs.SetInt(normalHighScore, finalScore);
                }
            }

            else if(getMode == 2){
                int getScore = PlayerPrefs.GetInt(extremeHighScore);
                if(finalScore > getScore){
                    PlayerPrefs.SetInt(extremeHighScore, finalScore);
                }
            }
        }
        
    }
}
