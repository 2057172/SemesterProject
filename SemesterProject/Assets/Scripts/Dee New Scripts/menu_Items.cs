using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class menu_Items : MonoBehaviour

{

    public GameManager gm;

    public Button OrderButtonOne, OrderButtonTwo, OrderButtonThree;

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

    public string[] Foods2 = new string[]
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

    public string[] Foods3 = new string[]
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

    public string pickfood1, pickfood2, pickfood3, pickfood4, pickfood5, pickfood6, pickplanet;

   /* public void choosingRandomFoods()
    {
        System.Random random = new System.Random();

        int useFoods1 = random.Next(Foods.Length);
        pickfood1 = Foods[useFoods1];


        int useFoods2 = random.Next(Foods.Length);
        pickfood2 = Foods[useFoods2];


        int useFoods3 = random.Next(Foods.Length);
        pickfood3 = Foods[useFoods3];



        print(pickfood1);
        print(pickfood2);
        print(pickfood3);

        Debug.Log(useFoods1.ToString() + useFoods2.ToString() + useFoods3.ToString());

    } */
    public void Start()
    {
        //choosingRandomPlanet();
        //choosingRandomFoods();
        RefreshOrders();

        gm.takeBurgerAndFriedOrder.GetComponentInChildren<Text>().text = pickfood1 + ", " + pickfood2 + ", " + pickfood3;
        gm.takeIceCreamOrder.GetComponentInChildren<Text>().text = pickfood4 + "," + pickfood5 + "," + pickfood6;

    }

    public void Update()
    {
        
    }

    //DECIDES WHERE THE ORDER WILL BE PLACED 
   /* public void choosingRandomPlanet()
    {

        System.Random random = new System.Random();
        int usePlanets = random.Next(Planets.Length);
        string pickPlanet = Planets[usePlanets];
        print(pickPlanet);

        pickplanet = pickPlanet;

    } */

    public void RefreshOrders()
    {
        for(int count = 0; count < 3; count++)
        {
            Debug.Log(count);

            if (count == 0)
            {
                System.Random random = new System.Random();
                int usePlanets = random.Next(Planets.Length);
                string pickPlanet = Planets[usePlanets];
                print(pickPlanet);

                pickplanet = pickPlanet;

                System.Random random1 = new System.Random();

                int useFoods1 = random1.Next(Foods.Length);
                pickfood1 = Foods[useFoods1];
                Debug.Log("This is" + useFoods1);


                int useFoods2 = random1.Next(Foods.Length);
                pickfood2 = Foods[useFoods2];
                Debug.Log("This is" + useFoods2);

                int useFoods3 = random1.Next(Foods.Length);
                pickfood3 = Foods[useFoods3];
                Debug.Log("This is" + useFoods3);

                OrderButtonOne.gameObject.GetComponentInChildren<Text>().text = pickfood1 + ", " + pickfood2 + ", " + pickfood3 + ". To " + pickplanet;

            } 
            if(count == 1)
            {
                System.Random random3 = new System.Random();
                int usePlanets = random3.Next(Planets.Length);
                string pickPlanet = Planets[usePlanets];
                print(pickPlanet);

                pickplanet = pickPlanet;

                System.Random random4 = new System.Random();
                int random4New = Random.Range(0, Foods.Length); 

                int useFoods4 = random4.Next(Foods.Length);
                pickfood4 = Foods[useFoods4];
                Debug.Log("This is" + random4New);
                Debug.Log("Order 2.1 is: " + Foods[useFoods4]);


                int useFoods5 = random4.Next(Foods.Length);
                pickfood5 = Foods[useFoods5];
                Debug.Log("This is" + useFoods5);
                Debug.Log("Order 2.2 is: " + Foods[useFoods5]);


                int useFoods6 = random4.Next(Foods.Length);
                pickfood6 = Foods[useFoods6];
                Debug.Log("This is" + useFoods6);
                Debug.Log("Order 2.3 is: " + Foods[useFoods6]);

                OrderButtonTwo.gameObject.GetComponentInChildren<Text>().text = pickfood4 + ", " + pickfood5 + ", " + pickfood6 + ". To " + pickplanet;
            }
            if (count == 2)
            {
                System.Random random5 = new System.Random();
                int usePlanets = random5.Next(Planets.Length);
                string pickPlanet = Planets[usePlanets];
                print(pickPlanet);

                pickplanet = pickPlanet;

                System.Random random6 = new System.Random();

                int useFoods1 = random6.Next(Foods3.Length);
                pickfood1 = Foods3[useFoods1];


                int useFoods2 = random6.Next(Foods3.Length);
                pickfood2 = Foods3[useFoods2];


                int useFoods3 = random6.Next(Foods3.Length);
                pickfood3 = Foods3[useFoods3];

                OrderButtonThree.gameObject.GetComponentInChildren<Text>().text = pickfood1 + ", " + pickfood2 + ", " + pickfood3 + ". To " + pickplanet;
            } 
        }


    }

   


}

   


