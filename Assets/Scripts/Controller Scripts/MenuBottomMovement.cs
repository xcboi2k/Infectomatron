using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBottomMovement : MonoBehaviour
{
    public static int movespeed = 7;
    public Vector3 userDirection = Vector3.up;

    void Update()
    {
        transform.Translate(userDirection * movespeed * Time.deltaTime);
        Destroy(gameObject, 4.0f);
    }
}
