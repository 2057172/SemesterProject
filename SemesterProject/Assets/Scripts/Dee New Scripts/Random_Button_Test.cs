using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Random_Button_Test : MonoBehaviour
{

    public string[] Foods = new string[]
    {
        "Single Cheeseburger",
        "Double Cheeseburger",
        "Steak",
        "Ribs",
        "Taco",
        "Noodles",
        "Pizza",
        "Hot Wings",
        "Chicken Piece",
        "Sushi 1",
        "Sushi 2",
        "Sushi 3",
        "Fried Fish",
        "Fried Calamari",
        "Fried Prawns",
        "Salad",
        "Chips",
        "Onion Rings",
        "Rice",
        "Doughnuts",
        "Ice Cream",
        "Cupcakes",
        "Waffles",
        "Milkshake",
        "Water",
        "Juice",
        "Alchol",
        "Cold Drink",

        //EARTH PLANET
        "Human Food",

        //JUNGLE PLANET
        "Bugs",

        //LAVA PLANET
        "Lava Drink",

        //PILLOW PLANET
        "Warm Milk",

        //THE SUN
        "Sun food",

        
        //ICE PLANET 
        "Snow cone",

        
        //CAT PLANET
        "Cat food",

        //ROBOT PLANET
        "Nuts and Bolts",


        //LSD PLANET
        "Space Shrooms",

        //GAS PLANET
        "Helium",

        //DISCO PLANET
        "Energy Drink",

        
        // WEED PLANET
        "Joint",

        //BOUGIE PLANET
        "Diamond Caviar",


        //LOVECRAFT PLANET
        "THE VOID",
    };




    public void Start()
    {
        
        choosingRandomIncorrectFoods();
       
       


    }

    public void Update()
    {

    }



    public void choosingRandomIncorrectFoods()
    {
        System.Random random = new System.Random();

        int useFoods1 = random.Next(Foods.Length);
        string pickfood1 = Foods[useFoods1];


        int useFoods2 = random.Next(Foods.Length);
        string pickfood2 = Foods[useFoods2];


        int useFoods3 = random.Next(Foods.Length);
        string pickfood3 = Foods[useFoods3];

        
        GetComponentInChildren<TMPro.TextMeshProUGUI>().text = useFoods1.ToString() + useFoods2.ToString() + useFoods3.ToString();
    }


}
