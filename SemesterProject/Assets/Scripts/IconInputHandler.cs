using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconInputHandler : MonoBehaviour
{
    public MapIconMovement pm;
    public bool moving;
    public playerStuck ps;

    private void Awake()
    {
        pm = GetComponent<MapIconMovement>();
    }

    void Update()
    {
        /* if (ps.moving == true)
        {
            Vector2 inputVector = Vector2.zero;

            inputVector.x = Input.GetAxis("Horizontal");
            inputVector.y = Input.GetAxis("Vertical");

            pm.SetInputVector(inputVector);
        }
        */

    }
}
