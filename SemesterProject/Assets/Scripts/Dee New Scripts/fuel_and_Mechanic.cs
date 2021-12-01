using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class fuel_and_Mechanic : MonoBehaviour
{


    public GameObject refuelPanel;
    public bool isAtFuelShop;
    public bool shopOP;
    public Text instruction;


    void Start()
    {
       // refuelPanel.SetActive(false); ?????
    }

    void Update()
    {
        /// when the rocket is in the vacinity of the mechanic, this is to open and close the panel with the options
        if (isAtFuelShop)
        {
            if (Input.GetKeyDown(KeyCode.E) && !shopOP)
            {
                refuelPanel.SetActive(true);
                shopOP = true;
                instruction.text = "Press E to close shop".ToString();
                Debug.Log("OPEN");
            }
            else if (Input.GetKeyDown(KeyCode.E) && shopOP)
            {
                refuelPanel.SetActive(false);
                shopOP = false;
                instruction.text = "Press E to open shop".ToString();
                Debug.Log("CLOSE");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            instruction.text = "Press E to open shop".ToString();
            isAtFuelShop = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            refuelPanel.SetActive(false);
            instruction.text = null;
        }
    }
}

