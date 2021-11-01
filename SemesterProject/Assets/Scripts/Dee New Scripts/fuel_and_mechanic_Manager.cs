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
        
    }

    void Update()
    {
        
    }

    public void payForFuel()
    {
        //BASE FUEL STATS
        //ENOUGH MONEY
        if (gameManager.money >= baseFuelCost)
        {
            gameManager.money = gameManager.money - fuelCost;
            gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);

            //AMOUNT FILLED UP 
            PlayerMovement.currentFuel = 100;
            Health_And_Fuel.setCurrentFuel(PlayerMovement.currentFuel);

            fuelAmountText.text = "$10";
        }

        //NOT ENOUGH MONEY
        if(gameManager.money < baseFuelCost)
        {
            
            gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
            fuelText.text = "You don't have enough money!";
        }


        //UPGRADE 1 FUEL STATS 
        //ENOUGH MONEY
        if (upgradeShop.fuelUP1purchased == true)
        {
            Debug.Log("Yee1");
            fuelCost = fuelUpgradeCost1;
            fuelAmountText.text = "$50";

            //ENOUGH MONEY
            if (gameManager.money >= fuelUpgradeCost1)
            {
                gameManager.money = gameManager.money - fuelCost;
                gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);

                //AMOUNT FILLED UP 
                PlayerMovement.currentFuel = 150;
                Health_And_Fuel.setCurrentFuel(PlayerMovement.currentFuel);
            }

            //NOT ENOUGH MONEY
            if (gameManager.money < fuelUpgradeCost1)
            {

                gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
                fuelText.text = "You don't have enough money!";
            }

        }


        //UPGRADE 2 FUEL STATS 
        //ENOUGH MONEY
        if (upgradeShop.fuelUP2purchased == true)
        {
            Debug.Log("Yee2");
            fuelCost = fuelUpgradeCost2;
            fuelAmountText.text = "$100";

            //ENOUGH MONEY
            if (gameManager.money >= fuelUpgradeCost2)
            {
                gameManager.money = gameManager.money - fuelCost;
                gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);

                //AMOUNT FILLED UP 
                PlayerMovement.currentFuel = 200;
                Health_And_Fuel.setCurrentFuel(PlayerMovement.currentFuel);
            }

            //NOT ENOUGH MONEY
            if (gameManager.money < fuelUpgradeCost2)
            {

                gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
                fuelText.text = "You don't have enough money!";
            }

        }


        //UPGRADE 3 FUEL STATS 
        //ENOUGH MONEY
        if (upgradeShop.fuelUP3purchased == true)
        {
            Debug.Log("Yee3");
            fuelCost = fuelUpgradeCost3;
            fuelAmountText.text = "$150";

            //ENOUGH MONEY
            if (gameManager.money >= fuelUpgradeCost3)
            {
                gameManager.money = gameManager.money - fuelCost;
                gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);

                //AMOUNT FILLED UP 
                PlayerMovement.currentFuel = 250;
                Health_And_Fuel.setCurrentFuel(PlayerMovement.currentFuel);
            }

            //NOT ENOUGH MONEY
            if (gameManager.money < fuelUpgradeCost3)
            {

                gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
                fuelText.text = "You don't have enough money!";
            }

        }
    }

    public void payforMechanic()
    {
        //BASE UPGRADE
        //ENOUGH MONEY
        if (gameManager.money >= baseMechanicCost)     
        {
            gameManager.money = gameManager.money - repairCost;
            gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
            repairAmountText.text = "$20";

            //AMOUNT FILLED UP 
            PlayerMovement.currentHealth = 100;
            Health_And_Fuel.setCurrentHealth(PlayerMovement.currentHealth);
        }

        //NOT ENOUGH MONEY
        if (gameManager.money < baseMechanicCost)
        {
            gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
            repairText.text = "You don't have enough money!";
        }




        //UPGRADE 1 REPAIR STATS 
        //ENOUGH MONEY
        if (upgradeShop.healthUP1purchased == true)
        {
            Debug.Log("Nee1");
            repairCost = mechanicUpgradeCost1;
            repairAmountText.text = "$100";

            //ENOUGH MONEY
            if (gameManager.money >= mechanicUpgradeCost1)
            {
                gameManager.money = gameManager.money - fuelCost;
                gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);

                //AMOUNT FILLED UP 
                PlayerMovement.currentHealth = 150;
                Health_And_Fuel.setCurrentHealth(PlayerMovement.currentHealth);
            }

            //NOT ENOUGH MONEY
            if (gameManager.money < mechanicUpgradeCost1)
            {

                gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
                repairText.text = "You don't have enough money!";
            }



            //UPGRADE 2 REPAIR STATS 
            //ENOUGH MONEY
            if (upgradeShop.healthUP2purchased == true)
            {
                Debug.Log("Nee2");
                repairCost = 200;
                repairAmountText.text = "$200";

                //ENOUGH MONEY
                if (gameManager.money >= mechanicUpgradeCost2)
                {
                    gameManager.money = gameManager.money - fuelCost;
                    gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);

                    //AMOUNT FILLED UP 
                    PlayerMovement.currentHealth = 200;
                    Health_And_Fuel.setCurrentHealth(PlayerMovement.currentHealth);
                }

                //NOT ENOUGH MONEY
                if (gameManager.money < mechanicUpgradeCost2)
                {

                    gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
                    repairText.text = "You don't have enough money!";
                }

            }





            //UPGRADE 3 REPAIR STATS 
            //ENOUGH MONEY
            if (upgradeShop.healthUP3purchased == true)
            {
                Debug.Log("Nee3");
                repairCost = mechanicUpgradeCost3;
                repairAmountText.text = "$300";

                //ENOUGH MONEY
                if (gameManager.money >= mechanicUpgradeCost3)
                {
                    gameManager.money = gameManager.money - fuelCost;
                    gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);

                    //AMOUNT FILLED UP 
                    PlayerMovement.currentHealth = 250;
                    Health_And_Fuel.setCurrentHealth(PlayerMovement.currentHealth);
                }

                //NOT ENOUGH MONEY
                if (gameManager.money < mechanicUpgradeCost3)
                {

                    gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
                    repairText.text = "You don't have enough money!";
                }

            }

        }

    }
}
