using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class fuel_and_mechanic_Manager : MonoBehaviour
{
    public Sound_Manager sound_Manager;
    public GameManager gameManager;
    public health_and_fuel Health_And_Fuel;
    public playerMovement  PlayerMovement;
    public UpgradeShop upgradeShop;

    public int fuelCost;
    public TMP_Text fuelText;
    public TMP_Text fuelAmountText;
  
    public int repairCost;
  

    public int baseFuelCost = 10;
    public int fuelAfterUpgradeCost1 = 50;
    public int fuelAfterUpgradeCost2 = 100;
    public int fuelAfterUpgradeCost3 = 150;

    public int baseMechanicCost = 50;
    public int mechanicUpgradeCost1 = 100;
    public int mechanicUpgradeCost2 = 200;
    public int mechanicUpgradeCost3 = 300;

    public Button refuelButton;

    void Start()
    {
        fuelCost = 10;
        repairCost = 20;

        //refuelButton.GetComponentInChildren<TextMeshProUGUI>().text = "Refuel: " + "$" + fuelCost;
        fuelCost = baseFuelCost;
        repairCost = baseMechanicCost;

    }

    void Update()
    {
        //IF FUEL FULL
        if (PlayerMovement.currentFuel >= PlayerMovement.maxFuel)
        {
            refuelButton.interactable = false;
        }
        else if(PlayerMovement.currentFuel < PlayerMovement.maxFuel)
        {
            refuelButton.interactable = true;
        }
 
        if (upgradeShop.fuelUP1purchased == true)
        {
            fuelCost = fuelAfterUpgradeCost1;
           // refuelButton.GetComponentInChildren<TextMeshProUGUI>().text = "Refuel: " + "$" + fuelCost;

        }

        if (upgradeShop.fuelUP2purchased == true)
        {
            fuelCost = fuelAfterUpgradeCost2;
            //refuelButton.GetComponentInChildren<TextMeshProUGUI>().text = "Refuel: " + "$" + fuelCost;
        }

        if (upgradeShop.fuelUP3purchased == true)
        {
            fuelCost = fuelAfterUpgradeCost3;
           // refuelButton.GetComponentInChildren<TextMeshProUGUI>().text = "Refuel: " + "$" + fuelCost;
        }
        

        //Debug.Log(fuelCost);

      


        if (upgradeShop.healthUP1purchased == true)
        {
            repairCost = mechanicUpgradeCost1;
          
        }

        if (upgradeShop.healthUP2purchased == true)
        {
            repairCost = mechanicUpgradeCost2;
            
        }

        if (upgradeShop.healthUP3purchased == true)
        {
            repairCost = mechanicUpgradeCost3;
           
        }
 
    }

    public void payForFuel()
    {
        

        //BASE FUEL STATS
        //ENOUGH MONEY
        if (fuelCost == baseFuelCost)
        {
            if (gameManager.money >= fuelCost)
            {
                gameManager.money = gameManager.money - fuelCost;
                
                //AMOUNT FILLED UP 
                PlayerMovement.currentFuel = upgradeShop.baseFuel;
                Health_And_Fuel.setCurrentFuel(PlayerMovement.currentFuel);

                sound_Manager.orderPositive();
            }
        }

        //NOT ENOUGH MONEY
        if(gameManager.money < fuelCost)
        {
            
            gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
            fuelText.text = "You don't have enough money!";
        }


        //UPGRADE 1 FUEL STATS 
        //ENOUGH MONEY
        if (fuelCost == fuelAfterUpgradeCost1)
        {
            if (gameManager.money >= fuelCost)
            {
                gameManager.money = gameManager.money - fuelCost;
                gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);

                //AMOUNT FILLED UP 
                PlayerMovement.currentFuel = upgradeShop.maxFuelUpgrade1;
                Health_And_Fuel.setCurrentFuel(PlayerMovement.currentFuel);
            }
        }

        //NOT ENOUGH MONEY
        if (gameManager.money < fuelCost)
        {

            gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
            fuelText.text = "You don't have enough money!";
        }



        //UPGRADE 2 FUEL STATS 
        //ENOUGH MONEY
        if (fuelCost == fuelAfterUpgradeCost2)
        {
            if (gameManager.money >= fuelCost)
            {
                gameManager.money = gameManager.money - fuelCost;
                gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);

                //AMOUNT FILLED UP 
                PlayerMovement.currentFuel = upgradeShop.maxFuelUpgrade2;
                Health_And_Fuel.setCurrentFuel(PlayerMovement.currentFuel);
            }
        }

        //NOT ENOUGH MONEY
        if (gameManager.money < fuelCost)
        {

            gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
            fuelText.text = "You don't have enough money!";
        }


        //UPGRADE 3 FUEL STATS 
        //ENOUGH MONEY
        if (fuelCost == fuelAfterUpgradeCost3)
        {
            if (gameManager.money >= fuelCost)
            {
                gameManager.money = gameManager.money - fuelCost;
                gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);

                //AMOUNT FILLED UP 
                PlayerMovement.currentFuel = upgradeShop.maxFuelUpgrade1;
                Health_And_Fuel.setCurrentFuel(PlayerMovement.currentFuel);
            }
        }

        //NOT ENOUGH MONEY
        if (gameManager.money < fuelCost)
        {

            gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
            fuelText.text = "You don't have enough money!";
        }











    }

    public void payforMechanic()
    {
        //BASE UPGRADE
        //ENOUGH MONEY
        if (repairCost == baseMechanicCost)
        {
            if (gameManager.money >= repairCost)
            {
                gameManager.money = gameManager.money - repairCost;
                gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);

                //AMOUNT FILLED UP 
                PlayerMovement.currentHealth = upgradeShop.baseHealth;
                Health_And_Fuel.setCurrentHealth(PlayerMovement.currentHealth);
                sound_Manager.orderPositive();
            }
        }

        //NOT ENOUGH MONEY
        if (gameManager.money < repairCost)
        {

            gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
            
        }




        //UPGRADE 1
        //ENOUGH MONEY
        if (repairCost == mechanicUpgradeCost1)
        {
            if (gameManager.money >= repairCost)
            {
                gameManager.money = gameManager.money - repairCost;
                gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);

                //AMOUNT FILLED UP 
                PlayerMovement.currentHealth = upgradeShop.maxHealthUpgrade1;
                Health_And_Fuel.setCurrentHealth(PlayerMovement.currentHealth);
            }
        }

        //NOT ENOUGH MONEY
        if (gameManager.money < repairCost)
        {

            gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
            
        }


        //UPGRADE 2
        //ENOUGH MONEY
        if (repairCost == mechanicUpgradeCost2)
        {
            if (gameManager.money >= repairCost)
            {
                gameManager.money = gameManager.money - repairCost;
                gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);

                //AMOUNT FILLED UP 
                PlayerMovement.currentHealth = upgradeShop.maxHealthUpgrade2;
                Health_And_Fuel.setCurrentHealth(PlayerMovement.currentHealth);
            }
        }

        //NOT ENOUGH MONEY
        if (gameManager.money < repairCost)
        {

            gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
            
        }


        //UPGRADE 3
        //ENOUGH MONEY
        if (repairCost == mechanicUpgradeCost3)
        {
            if (gameManager.money >= repairCost)
            {
                gameManager.money = gameManager.money - repairCost;
                gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);

                //AMOUNT FILLED UP 
                PlayerMovement.currentHealth = upgradeShop.maxHealthUpgrade3;
                Health_And_Fuel.setCurrentHealth(PlayerMovement.currentHealth);
            }
        }

        //NOT ENOUGH MONEY
        if (gameManager.money < repairCost)
        {

            gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
            
        }



    }
}
