using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health_and_fuel : MonoBehaviour
{
    public Slider health_Bar;
    public Slider fuel_Bar;


    //HEALTH STAT
    public void setMaxHealth(int health)
    {
        health_Bar.maxValue = health;
        health_Bar.value = health; 
    }

    public void setCurrentHealth(int health)
    {
        health_Bar.value = health;
    }

    //FUEL STAT
    public void setMaxFuel(int fuel)
    {
        fuel_Bar.maxValue = fuel;
        fuel_Bar.value = fuel;
    }

    public void setCurrentFuel(int fuel)
    {
        fuel_Bar.value =fuel;

    }

}
