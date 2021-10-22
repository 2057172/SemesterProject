using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterScript : MonoBehaviour
{

    public Transform pos;
    void Start()
    {
        pos.position = new Vector3(Screen.width / 2, Screen.height / 2, 0f);
    }

    void Update()
    {
        pos.position = new Vector3(Screen.width / 2, Screen.width / 2, 0f);
    }
}
