using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class menu_Items : MonoBehaviour

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




    public string[] Planets = new string[]
    {
        //START ZONE
        "Earth Planet",
        "Jungle Planet",

         //HEAT ZONE
        "Lava Planet",
        "Pillow Planet",
        "The Sun",
        
        //ICE ZONE
        "Ice Planet",
        "Cat Planet",
        "Robot Planet",

        //RADIATION ZONE
        "LSD Planet",
        "Lovecraft Planet",
        "Disco Planet",

        //HARDCORE ZONE
        "Gas Planet",
        "Bougie Planet",
        "Weed Planet",
    };

    public void Start()
    {
        choosingRandomPlanet();
        choosingRandomFoods();
    }

    public void Update()
    {
        
    }

    //DECIDES WHERE THE ORDER WILL BE PLACED 
    public void choosingRandomPlanet()
    {

        System.Random random = new System.Random();
        int usePlanets = random.Next(Planets.Length);
        string pickPlanet = Planets[usePlanets];
        print(pickPlanet);



    }

    public void choosingRandomFoods()
    {
        System.Random random = new System.Random();
        
        int useFoods1 = random.Next(Foods.Length);
        string pickfood1 = Foods[useFoods1];

        
        int useFoods2 = random.Next(Foods.Length);
        string pickfood2 = Foods[useFoods2];

        
        int useFoods3 = random.Next(Foods.Length);
        string pickfood3 = Foods[useFoods3];

     

        print(pickfood1);
        print(pickfood2);
        print(pickfood3);

        Debug.Log(useFoods1.ToString() + useFoods2.ToString() + useFoods3.ToString());
             
    }


}

   


