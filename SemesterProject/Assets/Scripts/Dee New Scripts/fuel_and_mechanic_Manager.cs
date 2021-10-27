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
  
    public int repairCost;
    public TMP_Text repairText;


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
        //ENOUGH MONEY
        if (gameManager.money >=10)
        {
            gameManager.money = gameManager.money - fuelCost;
            gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);

            //AMOUNT FILLED UP 
            PlayerMovement.currentFuel = 100;
            Health_And_Fuel.setCurrentFuel(PlayerMovement.currentFuel);
        }

        //NOT ENOUGH MONEY
        if(gameManager.money < 10)
        {
            
            gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
            fuelText.text = "You don't have enough money!";
        }
    }

    public void payforMechanic()
    {
        //ENOUGH MONEY
        if (gameManager.money >= 20)
        {
            gameManager.money = gameManager.money - repairCost;
            gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);

            //AMOUNT FILLED UP 
            PlayerMovement.currentHealth = 100;
            Health_And_Fuel.setCurrentHealth(PlayerMovement.currentHealth);
        }

        //NOT ENOUGH MONEY
        if (gameManager.money < 20)
        {
            gameManager.money = gameManager.money;
            gameManager.moneyTXT.text = "$" + Mathf.RoundToInt(gameManager.money);
            repairText.text = "You don't have enough money!";
        }
    }
}
