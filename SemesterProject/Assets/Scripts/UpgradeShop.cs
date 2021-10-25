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
    
    /// <summary>
    /// All of the variables for the once off upgrades
    /// </summary>
        
    public GameManager gameMan;

    public int firePro;
    public int icePro;
    public int radPro;

    [SerializeField] private bool firePurchased;
    [SerializeField] private bool icePurchased;
    [SerializeField] private bool radPurchased;

    public Button heatButton;
    public Button iceButton;
    public Button radButton;

    /// <summary>
    /// All of the varuables for the fuel upgrades
    /// </summary>

    public playerMovement playerMov;

    public int FuelUp1;
    public int FuelUp2;
    public int FuelUp3;

    [SerializeField] private bool fuelUP1purchased;
    [SerializeField] private bool fuelUP2purchased;
    [SerializeField] private bool fuelUP3purchased;

    public Button fuelUp1Button;
    public Button fuelUp2Button;
    public Button fuelUp3Button;

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

        ///Once Off Upgrades things
        
        // if the money is equal or less than 0, then it stays at 0

        if (gameMan.money <= 0)
        {
            gameMan.money = 0;
            heatButton.interactable = false;
            iceButton.interactable = false;
            radButton.interactable = false;
            fuelUp1Button.interactable = false;
            fuelUp2Button.interactable = false;
            fuelUp3Button.interactable = false;
        }

        // if you don't have enough money for a upgrade, you cannot purchase it

        if (gameMan.money < firePro || firePurchased)
        {
            //can't purchase fire protection
            heatButton.interactable = false;
        }
        else
        {
            heatButton.interactable = true;
        }

        if (gameMan.money < icePro || icePurchased)
        {
            //can't purchase ice protection
            iceButton.interactable = false;
        }
        else
        {
            iceButton.interactable = true;
        }

        if (gameMan.money < radPro || radPurchased)
        {
            //can't purchase radiation protection
            radButton.interactable = false;
        }
        else
        {
            radButton.interactable = true;
        }

        /// Fuel Upgrade Things

        if (gameMan.money < FuelUp1)        // If you don't have enough money for Fuel UPgrade 1
        {
            fuelUp1Button.interactable = false;
        }
        else
        {
            fuelUp1Button.interactable = true;
        }
        if (gameMan.money < FuelUp2)        // If you don't have enough money for Fuel Upgrade 2
        {
            fuelUp2Button.interactable = false;
        }
        else
        {
            fuelUp2Button.interactable = true;
        }
        if (gameMan.money < FuelUp3)        // If you don't have enough money for Fuel Upgrade 3
        {
            fuelUp3Button.interactable = false;
        }
        else
        {
            fuelUp3Button.interactable = true;
        }


        if (fuelUP1purchased)              // If the player has already bought upgrade 1 
        {
            Debug.Log("FuelUp1 Purchased");
            fuelUp1Button.interactable = false;

        }
        if (fuelUP2purchased)               // If the player has already bought upgrade 2
        {
            Debug.Log("FuelUp2 Purchased");
            fuelUp2Button.interactable = false;
        }
        if (fuelUP3purchased)               // If the player has already bought upgrade 3
        {
            Debug.Log("FuelUp3 Purchased");
            fuelUp3Button.interactable = false;
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
        if (gameMan.money >= firePro)
        {
            gameMan.money -= firePro;
            firePurchased = true;
        }
        else
        {
            firePurchased = false;
        }
    }

    public void Upgrade2()
    {
        if (gameMan.money >= icePro)
        {
            gameMan.money -= icePro;
            icePurchased = true;
        }
        else
        {
            icePurchased = false;
        } 
    }

    public void Upgrade3()
    {
        if (gameMan.money >= radPro)
        {
            gameMan.money -= radPro;
            radPurchased = true;
        }
        else
        {
            radPurchased = false;
        }
    }

    public void FuelUpgrade1()
    {
        if (gameMan.money >= FuelUp1)
        {
            gameMan.money -= FuelUp1;
            playerMov.maxFuel = 150;
            fuelUP1purchased = true;
        }
        else
        {
            fuelUP1purchased = false;
        }
       
    }

    public void FuelUpgrade2()
    {
        if (gameMan.money >= FuelUp2 && fuelUP1purchased)
        {
            gameMan.money -= FuelUp2;
            playerMov.maxFuel = 200;
            fuelUP2purchased = true;
        }
        else
        {
            fuelUP2purchased = false;
        }
    }

    public void FuelUpgrade3()
    {
        if (gameMan.money >= FuelUp3 && fuelUP2purchased)
        {
            gameMan.money -= FuelUp3;
            playerMov.maxFuel = 250;
            fuelUP3purchased = true;
        }
        else
        {
            fuelUP3purchased = false;
        }
    }
}
