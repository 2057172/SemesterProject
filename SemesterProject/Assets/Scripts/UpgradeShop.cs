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

        if (gameMan.money >= FuelUp1)
        {
            fuelUp1Button.interactable = true;
            fuelUp2Button.interactable = false;
            fuelUp3Button.interactable = false;
        }
        if (gameMan.money < FuelUp1)
        {
            fuelUp1Button.interactable = false;
            fuelUp2Button.interactable = false;
            fuelUp3Button.interactable = false;
        }

        if (fuelUP1purchased)
        {
            fuelUp1Button.interactable = false;
            fuelUp2Button.interactable = true;
            fuelUp3Button.interactable = false;
        }

        if (fuelUP2purchased)
        {
            fuelUp1Button.interactable = false;
            fuelUp2Button.interactable = false;
            fuelUp3Button.interactable = true;
        }

        if (fuelUP3purchased)
        {
            fuelUp1Button.interactable = false;
            fuelUp2Button.interactable = false;
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
        gameMan.money -= firePro;
        firePurchased = true;

    }

    public void Upgrade2()
    {
        gameMan.money -= icePro;
        icePurchased = true;
    }

    public void Upgrade3()
    {
        gameMan.money -= radPro;
        radPurchased = true;
    }

    public void FuelUpgrade1()
    {
        gameMan.money -= FuelUp1;
        playerMov.maxHealth = 150;
        fuelUP1purchased = true;
    }

    public void FuelUpgrade2()
    {
        gameMan.money -= FuelUp2;
        playerMov.maxHealth = 200;
        fuelUP1purchased = true;
    }

    public void FuelUpgrade3()
    {
        gameMan.money -= FuelUp3;
        playerMov.maxHealth = 250;
        fuelUP3purchased = true;
    }
}
