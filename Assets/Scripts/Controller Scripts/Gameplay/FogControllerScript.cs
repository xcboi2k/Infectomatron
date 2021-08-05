using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogControllerScript : MonoBehaviour
{
    public GameObject fog;

    float fogTimer = 30f;
    float fogActivationTime = 30f;
    float fogWaitingTime;
    float fogTime;

    void Start() {
        fogWaitingTime = 0f;
        fogTime = 0f;
    }
    void Update()
    {
        fogWaitingTime += Time.deltaTime;

        if(fogWaitingTime > fogActivationTime){
            fog.SetActive(true);
            Debug.Log("The fog is thick.");
            fogTime += Time.deltaTime;
            if(fogTime > fogTimer){
                fog.SetActive(false);
                Debug.Log("The fog is gone.");
                fogWaitingTime = 0f;
                fogTime = 0f;
            }
        }
    }
}
