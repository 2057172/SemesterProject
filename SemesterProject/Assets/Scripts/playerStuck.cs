using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStuck : MonoBehaviour
{
    private float checkTime = 0.001f;
    private Vector2 oldPos;
    public IconInputHandler iconInput;
    public MapIconMovement icon;
    public bool moving;

    private void Update()
    {
        if(checkTime <= 0)
        {
            oldPos = transform.position;
            checkTime = 0.01f;
        }
        else
        {
            checkTime -= Time.deltaTime;
        }

    } 
}
