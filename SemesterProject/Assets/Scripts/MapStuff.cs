using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapStuff : MonoBehaviour
{
    public Transform playerPos;
    public Transform offScreenPos;
    public float speed;

    void Update()
    {
        if(Input.GetKey(KeyCode.M))
        {
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
        } else
        {
            transform.position = Vector2.MoveTowards(transform.position, offScreenPos.position, speed * Time.deltaTime);
        }
       
    }
}
