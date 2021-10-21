using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpgradeShop : MonoBehaviour
{
    public GameObject repairPanel;
    public bool isAtShop;
    public bool shopOP;
   
    public Text instruction;

    // Start is called before the first frame update
    void Start()
    {
        repairPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isAtShop)
        {
            if (Input.GetKeyDown(KeyCode.E) && !shopOP)
            {
                repairPanel.SetActive(true);
                shopOP = true;
                instruction.text = "Press E to close shop".ToString();
                Debug.Log("OPEN");
            }
            else if (Input.GetKeyDown(KeyCode.E)&& shopOP)
            {
                repairPanel.SetActive(false);
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
            isAtShop = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            repairPanel.SetActive(false);
            instruction.text = null; 
        }
    }
}
