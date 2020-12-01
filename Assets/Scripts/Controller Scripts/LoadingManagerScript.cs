using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingManagerScript : MonoBehaviour
{
    public Slider loadingBar;
    float loadingTime = 0f;

    private const string selectedGameMode = "Game Mode";

    // Update is called once per frame
    void Update()
    {
        loadingTime += Time.deltaTime;

        loadingBar.value = loadingTime;

        if(loadingTime >= 30f){
            int getMode = PlayerPrefs.GetInt(selectedGameMode);

            if(getMode == 1){
                SceneManager.LoadScene("NormalGameplayScene");
            }
            else{
                SceneManager.LoadScene("ExtremeGameplayScene");
            }
        }

        Debug.Log(loadingTime);
    }
}
