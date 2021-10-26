using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapIconMovement : MonoBehaviour
{

    public Transform playerpos;
    public Camera cam;

    private void Awake()
    {
        
    }
    public void Update()
    {
        Vector3 screenPos = cam.ScreenToWorldPoint(playerpos.position);
        gameObject.GetComponent<Transform>().position = screenPos;
        //gameObject.GetComponent<Transform>().position = new Vector2((playerpos.position.x / 106.667f), (playerpos.position.y / 181.818f));
    }
    
}
