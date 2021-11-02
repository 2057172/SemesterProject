using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class fuel_and_mechanic_Manager : MonoBehaviour
{
    public GameManager gameManager;
    public health_and_fuel Health_And_Fuel;
    public playerMovement  PlayerMovement;
    public UpgradeShop upgradeShop;

    public int fuelCost;
    public TMP_Text fuelText;
    public TMP_Text fuelAmountText;
  
    public int repairCost;
    public TMP_Text repairText;
    public TMP_Text repairAmountText;

    public int baseFuelCost = 10;
    public int fuelUpgradeCost1 = 50;
    public int fuelUpgradeCost2= 100;
    public int fuelUpgradeCost3 = 150;

    public int baseMechanicCost = 50;
    public int mechanicUpgradeCost1 = 100;
    public int mechanicUpgradeCost2 = 200;
    public int mechanicUpgradeCost3 = 300;


    void Start()
    {
        fuelCost = 10;
        repairCost = 20;

        fuelAmountText.text = "$10";
        fuelCost = baseFuelCost;
        repairCost = baseMechanicCost;

    }

    void Update()
    {

        if (upgradeShop.fuelUP1purchased == true)
        {
            fuelCost = fuelUpgradeCost1;
            fuelAmountText.text = "$50";
        }

        if (upgradeShop.fuelUP2purchased == true)
        {
            fuelCost = fuelUpgradeCost2;
            fuelAmountText.text = "$100";
        }

        if (upgradeShop.fuelUP3purchased == true)
        {
            fuelCost = fuelUpgradeCost3;
            fuelAmountText.text = "$150";
        }
        

        //Debug.Log(fuelCost);

      


        if (upgradeShop.healthUP1purchased == true)
        {
            repairCost = mechanicUpgradeCost1;
            repairAmountText.text = "$100";
        }

        if (upgradeShop.healthUP2purchased == true)
        {
            repairCost = mechanicUpgradeCost2;
            repairAmountText.text = "$200";
        }

        if (upgradeShop.healthUP3purchased == true)
        {
            repairCost = mechanicUpgradeCost3;
            repairAmountText.text = "$300";
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
                gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);

                //AMOUNT FILLED UP 
                PlayerMovement.currentFuel = upgradeShop.baseFuel;
                Health_And_Fuel.setCurrentFuel(PlayerMovement.currentFuel);
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
        if (fuelCost == fuelUpgradeCost1)
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
        if (fuelCost == fuelUpgradeCost2)
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
        if (fuelCost == fuelUpgradeCost3)
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

    public void oof()
    {
        Debug.Log("DHDH");
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
            }
        }

        //NOT ENOUGH MONEY
        if (gameManager.money < repairCost)
        {

            gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
            repairText.text = "You don't have enough money!";
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
            repairText.text = "You don't have enough money!";
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
            repairText.text = "You don't have enough money!";
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
            repairText.text = "You don't have enough money!";
        }



    }
}
