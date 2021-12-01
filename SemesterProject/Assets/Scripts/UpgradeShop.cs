using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradeShop : MonoBehaviour
{
   
    
    /// <summary>
    /// All of the variables for the once off upgrades
    /// </summary>
        
    public GameManager gameMan;

    public int icePro;
    public int firePro;
    public int radPro;
    public int hardcorePro;

    
    [SerializeField] public bool icePurchased;
    [SerializeField] public bool firePurchased;
    [SerializeField] public bool radPurchased;
    [SerializeField] public bool hardcorePurchased;

    
    public Button iceButton;
    public Button heatButton;
    public Button radButton;
    public Button hardcoreButton;

    /// <summary>
    /// All of the varuables for the fuel upgrades
    /// </summary>

    public playerMovement playerMov;

    public int FuelUp1Cost;
    public int FuelUp2Cost;
    public int FuelUp3Cost;

    [SerializeField] public bool fuelUP1purchased;
    [SerializeField] public bool fuelUP2purchased;
    [SerializeField] public bool fuelUP3purchased;

    public Button fuelUp1Button;
    public Button fuelUp2Button;
    public Button fuelUp3Button;

    public int baseFuel = 100;
    public int maxFuelUpgrade1 =150;
    public int maxFuelUpgrade2 =200;
    public int maxFuelUpgrade3 =250;

    /// <summary>
    /// All of the variables for the health upgrades
    /// </summary>


    public int HealthUp1Cost;
    public int HealthUp2Cost;
    public int HealthUp3Cost;

    [SerializeField] public bool healthUP1purchased;
    [SerializeField] public bool healthUP2purchased;
    [SerializeField] public bool healthUP3purchased;

    public Button healthUp1Button;
    public Button healthUp2Button;
    public Button healthUp3Button;

    public int baseHealth = 100;
    public int maxHealthUpgrade1 = 150;
    public int maxHealthUpgrade2 = 200;
    public int maxHealthUpgrade3 = 250;

    /// <summary>
    /// All the variables to upgrade order capacity
    /// </summary>
    /// 


    public int carryCapUp1Cost;
    public int carryCapUp2Cost;
    public int carryCapUp3Cost;

    [SerializeField] public bool carryCapUP1purchased;
    [SerializeField] public bool carryCapUP2purchased;
    [SerializeField] public bool carryCapUP3purchased;

    public Button carryCapUp1Button;
    public Button carryCapUp2Button;
    public Button carryCapUp3Button;

    

    public fuel_and_mechanic_Manager repairScript;

    public Button repairButton;

    public TextMeshProUGUI priceTXT;


  

    // Start is called before the first frame update
    void Start()
    {

        heatButton.GetComponentInChildren<TextMeshProUGUI>().text = "Heat Protection: " + "$" + firePro;
        iceButton.GetComponentInChildren<TextMeshProUGUI>().text = "Ice Protection: " + "$" + icePro;
        radButton.GetComponentInChildren<TextMeshProUGUI>().text = "Radiation Protection: " + "$" + radPro;
        hardcoreButton.GetComponentInChildren<TextMeshProUGUI>().text = "Hardcore Proection: " + "$" + hardcorePro;

        healthUp1Button.GetComponentInChildren<TextMeshProUGUI>().text = "Health Upgrade 1: " + "$" + HealthUp1Cost;
        healthUp2Button.GetComponentInChildren<TextMeshProUGUI>().text = "Health Upgrade 2: " + "$" + HealthUp2Cost;
        healthUp3Button.GetComponentInChildren<TextMeshProUGUI>().text = "Health Upgrade 3: " + "$" + HealthUp3Cost;

        fuelUp1Button.GetComponentInChildren<TextMeshProUGUI>().text = "Fuel Upgrade 1: " + "$" + FuelUp1Cost;
        fuelUp2Button.GetComponentInChildren<TextMeshProUGUI>().text = "Fuel Upgrade 2: " + "$" + FuelUp2Cost;
        fuelUp3Button.GetComponentInChildren<TextMeshProUGUI>().text = "Fuel Upgrade 3: " + "$" + FuelUp3Cost;

        carryCapUp1Button.GetComponentInChildren<TextMeshProUGUI>().text = "Order Capacity Upgrade 1: " + "$" + carryCapUp1Cost;
        carryCapUp2Button.GetComponentInChildren<TextMeshProUGUI>().text = "Order Capacity Upgrade 2: " + "$" + carryCapUp2Cost;
        carryCapUp3Button.GetComponentInChildren<TextMeshProUGUI>().text = "Order Capacity Upgrade 3: " + "$" + carryCapUp3Cost;


        repairButton.GetComponentInChildren<TextMeshProUGUI>().text = "Repair Ship: " + "$" + repairScript.repairCost;
    }

    // Update is called once per frame
    void Update()
    {
        heatButton.GetComponentInChildren<TextMeshProUGUI>().text = "Heat Protection: " + "$" + firePro;
        iceButton.GetComponentInChildren<TextMeshProUGUI>().text = "Ice Protection: " + "$" + icePro;
        radButton.GetComponentInChildren<TextMeshProUGUI>().text = "Radiation Protection: " + "$" + radPro;
        hardcoreButton.GetComponentInChildren<TextMeshProUGUI>().text = "Hardcore Proection: " + "$" + hardcorePro;

        healthUp1Button.GetComponentInChildren<TextMeshProUGUI>().text = "Health Upgrade 1: " + "$" + HealthUp1Cost;
        healthUp2Button.GetComponentInChildren<TextMeshProUGUI>().text = "Health Upgrade 2: " + "$" + HealthUp2Cost;
        healthUp3Button.GetComponentInChildren<TextMeshProUGUI>().text = "Health Upgrade 3: " + "$" + HealthUp3Cost;

        fuelUp1Button.GetComponentInChildren<TextMeshProUGUI>().text = "Fuel Upgrade 1: " + "$" + FuelUp1Cost;
        fuelUp2Button.GetComponentInChildren<TextMeshProUGUI>().text = "Fuel Upgrade 2: " + "$" + FuelUp2Cost;
        fuelUp3Button.GetComponentInChildren<TextMeshProUGUI>().text = "Fuel Upgrade 3: " + "$" + FuelUp3Cost;

        carryCapUp1Button.GetComponentInChildren<TextMeshProUGUI>().text = "Order Capacity Upgrade 1: " + "$" + carryCapUp1Cost;
        carryCapUp2Button.GetComponentInChildren<TextMeshProUGUI>().text = "Order Capacity Upgrade 2: " + "$" + carryCapUp2Cost;
        carryCapUp3Button.GetComponentInChildren<TextMeshProUGUI>().text = "Order Capacity Upgrade 3: " + "$" + carryCapUp3Cost;


        repairButton.GetComponentInChildren<TextMeshProUGUI>().text = "Repair Ship: " + "$" + repairScript.repairCost;

        ///Once Off Upgrades things

        // if the money is equal or less than 0, then it stays at 0

        if (gameMan.money < 0)
        {
            gameMan.money = 0;
            heatButton.interactable = false;
            iceButton.interactable = false;
            radButton.interactable = false;
            hardcoreButton.interactable = false;
            fuelUp1Button.interactable = false;
            fuelUp2Button.interactable = false;
            fuelUp3Button.interactable = false;
            healthUp1Button.interactable = false;
            healthUp2Button.interactable = false;
            healthUp3Button.interactable = false;
            repairButton.interactable = false;
            carryCapUp1Button.interactable = false;
            carryCapUp2Button.interactable = false;
            carryCapUp3Button.interactable = false;
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


        if (gameMan.money < hardcorePro || hardcorePurchased)
        {
            //can't purchase radiation protection
            hardcoreButton.interactable = false;
        }
        else
        {
            hardcoreButton.interactable = true;
        }


        /// Fuel Upgrade Things

        if (gameMan.money < FuelUp1Cost || fuelUP1purchased)     // If you don't have enough money for Fuel Upgrade 1 or have purchased it
        {
            fuelUp1Button.interactable = false;
        }
        else
        {
            fuelUp1Button.interactable = true;
        }
        if (gameMan.money < FuelUp2Cost || fuelUP2purchased)     // If you don't have enough money for Fuel Upgrade 2 or have purchased it
        {
            fuelUp2Button.interactable = false;
        }
        else
        {
            fuelUp2Button.interactable = true;
        }
        if (gameMan.money < FuelUp3Cost || fuelUP3purchased)     // If you don't have enough money for Fuel Upgrade 3 or have purchased it
        {
            fuelUp3Button.interactable = false;
        }
        else
        {
            fuelUp3Button.interactable = true;
        }
        // Health Upgrade Things

        if (gameMan.money < HealthUp1Cost || healthUP1purchased)     // If you don't have enough money for Health Upgrade 1 or have purchased it
        {
            healthUp1Button.interactable = false;
           
        }
        else
        {
            healthUp1Button.interactable = true;
        }
        if (gameMan.money < HealthUp2Cost || healthUP2purchased)     // If you don't have enough money for Health Upgrade 2 or have purchased it
        {
            healthUp2Button.interactable = false;
        }
        else
        {
            healthUp2Button.interactable = true;
        }
        if (gameMan.money < HealthUp3Cost || healthUP3purchased)     // If you don't have enough money for Health Upgrade 3 or have purchased it
        {
            healthUp3Button.interactable = false;
        }
        else
        {
            healthUp3Button.interactable = true;
        }

        // Order Carry Capacity Things
        if (gameMan.money < carryCapUp1Cost|| carryCapUP1purchased)    
        {
            carryCapUp1Button.interactable = false;
        }
        else
        {
            carryCapUp1Button.interactable = true;
        }

        if (gameMan.money < carryCapUp2Cost || carryCapUP2purchased)
        {
            carryCapUp2Button.interactable = false;
        }
        else
        {
            carryCapUp2Button.interactable = true;
        }

        if (gameMan.money < carryCapUp3Cost || carryCapUP3purchased)
        {
            carryCapUp3Button.interactable = false;
        }
        else
        {
            carryCapUp3Button.interactable = true;
        }
    }


   

    public void UpgradeHeat()
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

    public void UpgradeIce()
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

    public void UpgradeRadiation()
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


    public void UpgradeHardcore()
    {

        if (gameMan.money >= hardcorePro)
        {
            gameMan.money -= hardcorePro;
            hardcorePurchased = true;
        }
        else
        {
            hardcorePurchased = false;
        }
    }

    public void FuelUpgrade1()
    {
        if (gameMan.money >= FuelUp1Cost)
        {
            gameMan.money -= FuelUp1Cost;
            playerMov.maxFuel = maxFuelUpgrade1;
            fuelUP1purchased = true;
        }
        else
        {
            fuelUP1purchased = false;
        }
       
    }

    public void FuelUpgrade2()
    {
        if (gameMan.money >= FuelUp2Cost && fuelUP1purchased)
        {
            gameMan.money -= FuelUp2Cost;
            playerMov.maxFuel = maxFuelUpgrade2;
            fuelUP2purchased = true;
        }
        else
        {
            fuelUP2purchased = false;
        }
    }

    public void FuelUpgrade3()
    {
        if (gameMan.money >= FuelUp3Cost && fuelUP2purchased)
        {
            gameMan.money -= FuelUp3Cost;
            playerMov.maxFuel = maxFuelUpgrade3;
            fuelUP3purchased = true;
        }
        else
        {
            fuelUP3purchased = false;
        }
    }

    public void HealthUpgrade1()
    {
        if (gameMan.money >= HealthUp1Cost)
        {
            gameMan.money -= HealthUp1Cost;
            playerMov.maxHealth = maxHealthUpgrade1;
            healthUP1purchased = true;
        }
        else
        {
            healthUP1purchased = false;
        }
    }

    public void HealthUpgrade2()
    {
        if (gameMan.money >= HealthUp2Cost && healthUP1purchased)
        {
            gameMan.money -= HealthUp2Cost;
            playerMov.maxHealth = maxHealthUpgrade2;
            healthUP2purchased = true;
        }
        else
        {
            healthUP2purchased = false;
        }
    }

    public void HealthUpgrade3()
    {
        if (gameMan.money >= HealthUp3Cost && healthUP2purchased)
        {
            gameMan.money -= HealthUp3Cost;
            playerMov.maxHealth = maxHealthUpgrade3;
            healthUP3purchased = true;
        }
        else
        {
            healthUP3purchased = false;
        }
    }

    public void CarryCapUpgrade1()
    {
        if (gameMan.money >= carryCapUp1Cost)
        {
            gameMan.money -= carryCapUp1Cost;
            carryCapUP1purchased = true;

            //DO SOMETHING
        }
        else
        {
            carryCapUP1purchased = false;
        }
    }


    public void CarryCapUpgrade2()
    {
        if (gameMan.money >= carryCapUp2Cost && carryCapUP1purchased)
        {
            gameMan.money -= carryCapUp2Cost;
            carryCapUP2purchased = true;

            //DO SOMETHING
        }
        else
        {
            carryCapUP2purchased = false;
        }
    }


    public void CarryCapUpgrade3()
    {
        if (gameMan.money >= carryCapUp3Cost && carryCapUP2purchased)
        {
            gameMan.money -= carryCapUp3Cost;
            carryCapUP3purchased = true;

            //DO SOMETHING
        }
        else
        {
            carryCapUP3purchased = false;
        }
    }
}
