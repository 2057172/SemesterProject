using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Stats : MonoBehaviour
{
    public health_and_fuel Health_And_Fuel;
    
    public int maxHealth =100;
    public int currentHealth;
    public int shipDamage= 10;

    public int maxFuel =100;
    public int currentFuel;
    public int fuel = 10;

    void Start()
    {
        currentHealth = maxHealth;
        Health_And_Fuel.setMaxHealth(maxHealth);

        currentFuel = maxFuel;
        Health_And_Fuel.setMaxFuel(maxFuel);
    }

    
    void Update()
    {
        fuelDecrease();
        StartCoroutine(fuelstuff());

    }


    void fuelDecrease()
    {
        //TEST CODE
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentFuel -= fuel;
            Health_And_Fuel.setCurrentFuel(currentFuel);

            if (currentFuel < 0)
            {
                currentFuel = 0;
            }
        }
       
    }

    bool running;
    public IEnumerator fuelstuff()
    {
       
        running = true;

       
        while (running)
        {
            // wait for seconds
            yield return new WaitForSeconds(5);
            currentFuel -= fuel;
            Health_And_Fuel.setCurrentFuel(currentFuel);
            yield break;
           

        }
    }

    void ShipCollision()
    {
        currentHealth -= shipDamage;
        Health_And_Fuel.setCurrentHealth(currentHealth);
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Collision")
        {
            ShipCollision();
        }
    }
}
