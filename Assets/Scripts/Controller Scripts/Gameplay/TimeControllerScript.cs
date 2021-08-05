using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControllerScript : MonoBehaviour
{
    float timeAttackTime = 60f;

    public Text countDownText;

    // Update is called once per frame
    void Update()
    {
        timeAttackTime -= Time.deltaTime;

        countDownText.text = Mathf.Floor(timeAttackTime).ToString();

        if(timeAttackTime < 0f){
            
            GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().isAlive = false;
            GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().stopCountingScore = true;
        }
    }
}
