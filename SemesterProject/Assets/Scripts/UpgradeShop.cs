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
    public GameManager gameMan;


    /// <summary>
    /// All of the variables for the once off upgrades
    /// </summary>
    public int firePro;
    public int icePro;
    public int radPro;

    // Start is called before the first frame update
    void Start()
    {
        repairPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /// when the rocket is in the vacinity of the mechanic, this is to open and close the panel with the options
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

        ///Upgrade things
        
        // if the money is equal or less than 0, then it stays at 0

        if (gameMan.money <= 0)
        {
            gameMan.money = 0;
        }

        // if you don't have enough money for a upgrade, you cannot purchase it

        if (gameMan.money < firePro)
        {
            //can't purchase fire protection
        }

        if (gameMan.money < icePro)
        {
            //can't purchase ice protection
        }

        if (gameMan.money < radPro)
        {
            //can't purchase radiation protection
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

    public void Upgrade1()
    {
        gameMan.money -= firePro;
    }

    public void Upgrade2()
    {
        gameMan.money -= icePro;
    }

    public void Upgrade3()
    {
        gameMan.money -= radPro;
    }
}
