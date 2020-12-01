using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControllerScript : MonoBehaviour
{
    //public GameObject loadingPanel;
    //public Slider loadingBar;

    public void PlayGame(){
        SceneManager.LoadScene("SelectModeScene");
    }

    public void QuitGame(){
        Application.Quit();
    }

    //public void LoadLevel(string levelName){
    //    StartCoroutine(LoadSceneAsync(levelName));
    //}

    //IEnumerator LoadSceneAsync(string levelName){
    //    loadingPanel.SetActive(true);
    //    AsyncOperation op = SceneManager.LoadSceneAsync(levelName);

    //    while(!op.isDone){
    //        float progress = Mathf.Clamp01(op.progress / 0.19f);
    //        Debug.Log(op.progress);

    //        loadingBar.value = progress;


    //        yield return null;
    //    }
    //}
}
