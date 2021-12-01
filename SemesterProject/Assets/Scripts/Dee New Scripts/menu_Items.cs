using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class menu_Items : MonoBehaviour

{

    public GameManager gm;
<<<<<<< Updated upstream
    public buttonLogic BL;
=======
    public Button OrderButtonOne, OrderButtonTwo, OrderButtonThree;
    public NewRandomPlanets newRandomPlanets;

    public UpgradeShop upgradeShop;
    public buttonLogic bl;
>>>>>>> Stashed changes

    public Button OrderButtonOne, OrderButtonTwo, OrderButtonThree, menuButton1, menuButton2, menuButton3;

    public Transform Earth, Forest, Ice, Metal, Cat, Sun, Sleep, Fire, Dance, Lovecraft, LSD, Weed, Bougie, Gas;

    public TextMeshProUGUI orderStatus;
    public bool OnOrder1, onOrder2, onOrder3;

<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
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

    public string pickfood1, pickfood2, pickfood3, pickfood4, pickfood5, pickfood6, pickfood7, pickfood8, pickfood9, pickplanet;
    public string planet1String;

<<<<<<< Updated upstream
 
=======
    public int orderCounter;


    public void getRandomPlanet()
    {
        for (int count = 0; count < 3; count++)
        {
            if (count == 0)
            {
                PlanetOutcome1 = Planets[Random.Range(0, Planets.Length)];
                planet1String = PlanetOutcome1.name;
                gm.OrderButton1.GetComponentInChildren<TextMeshProUGUI>().text = pickfood1 + ", " + pickfood2 + ", " + pickfood3 + ", "
                    + planet1String;
            }
            else if (count == 1)
            {
                PlanetOutcome2 = Planets[Random.Range(0, Planets.Length)];
            }
            else if (count == 2)
            {
                PlanetOutcome3 = Planets[Random.Range(0, Planets.Length)];
            }

        }
    }
>>>>>>> Stashed changes
    public void Start()
    {
        RefreshOrders();
        RefreshOrders();

        OnOrder1 = false;
        onOrder2 = false;
        onOrder3 = false;
<<<<<<< Updated upstream
      
        gm.OrderButton1.GetComponentInChildren<Text>().text = pickfood1 + ", " + pickfood2 + ", " + pickfood3;
        gm.OrderButton2.GetComponentInChildren<Text>().text = pickfood4 + "," + pickfood5 + "," + pickfood6;

        orderStatus.text = "";
=======

        Distance1TXT.gameObject.SetActive(false);
        Distance2TXT.gameObject.SetActive(false);
        Distance3TXT.gameObject.SetActive(false);

        Planet1.gameObject.SetActive(false);
        Planet2.gameObject.SetActive(false);
        Planet3.gameObject.SetActive(false);

        
        gm.OrderButton2.GetComponentInChildren<TextMeshProUGUI>().text = pickfood4 + "," + pickfood5 + "," + pickfood6 + ", " + PlanetOutcome2.name;

        orderStatus.text = "";
    }

    public void Update()
    {
        if (orderCounter <= 0)
        {
            orderCounter = 0;
        }
        if (orderCounter >= upgradeShop.maxOrderCapacity)
        {
            orderCounter = upgradeShop.maxOrderCapacity;
        }
>>>>>>> Stashed changes
    }

    

    public void Order1()
    {
        if (OnOrder1 == false)
        {
            OrderButtonOne.gameObject.SetActive(false);
            OnOrder1 = true;
<<<<<<< Updated upstream
=======
            orderCounter++;
            planet1Final = PlanetOutcome1;
            bl.planet1 = PlanetOutcome1;
>>>>>>> Stashed changes
        }


    }
    public void Order2()
    {
        if (onOrder2 == false)
        {
            OrderButtonTwo.gameObject.SetActive(false);
            onOrder2 = true;
<<<<<<< Updated upstream
=======
            orderCounter++;
            planet2Final = PlanetOutcome2;
            bl.planet2 = PlanetOutcome2;
>>>>>>> Stashed changes
        }
    }
    public void Order3()
    {
        if (onOrder3 == false)
        {
            OrderButtonThree.gameObject.SetActive(false);
            onOrder3 = true;
        }
    }

    public void RefreshOrders()
    {
        for(int count = 0; count < 3; count++)
        {
<<<<<<< Updated upstream
            Debug.Log(count);
=======
            
>>>>>>> Stashed changes

            if (count == 0)
            {
               
                System.Random random1 = new System.Random();

                int useFoods1 = Random.Range(0, Foods.Length);
                pickfood1 = Foods[useFoods1];
<<<<<<< Updated upstream
                Debug.Log("This is" + useFoods1);
=======
               
>>>>>>> Stashed changes


                int useFoods2 = Random.Range(0, Foods.Length);
                pickfood2 = Foods[useFoods2];
<<<<<<< Updated upstream
                Debug.Log("This is" + useFoods2);

                int useFoods3 = Random.Range(0, Foods.Length);
                pickfood3 = Foods[useFoods3];
                Debug.Log("This is" + useFoods3);
=======
            

                int useFoods3 = Random.Range(0, Foods.Length);
                pickfood3 = Foods[useFoods3];
       

                OrderButtonOne.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = pickfood1 + ", " + pickfood2 + ", " + pickfood3 + ", " + PlanetOutcome1.name;
                //menuButton1.gameObject.gameObject.GetComponentInChildren<Text>().text = pickfood1 + ", " + pickfood2 + ", " + pickfood3;

                orderStatus.text = "Order Picked Up.";
>>>>>>> Stashed changes

                OrderButtonOne.gameObject.GetComponentInChildren<Text>().text = pickfood1 + ", " + pickfood2 + ", " + pickfood3;
                //menuButton1.gameObject.gameObject.GetComponentInChildren<Text>().text = pickfood1 + ", " + pickfood2 + ", " + pickfood3;

<<<<<<< Updated upstream
                orderStatus.text = "Order Picked Up.";
            } 
            if(count == 1)
=======
            }
            if (count == 1)
>>>>>>> Stashed changes
            {
               

                System.Random random4 = new System.Random();
                int random4New = Random.Range(0, Foods.Length); 

                int useFoods4 = Random.Range(0, Foods.Length);
                pickfood4 = Foods[useFoods4];
<<<<<<< Updated upstream
                Debug.Log("This is" + random4New);
                Debug.Log("Order 2.1 is: " + Foods[useFoods4]);
=======
              
>>>>>>> Stashed changes


                int useFoods5 = Random.Range(0, Foods.Length);
                pickfood5 = Foods[useFoods5];
<<<<<<< Updated upstream
                Debug.Log("This is" + useFoods5);
                Debug.Log("Order 2.2 is: " + Foods[useFoods5]);
=======
               
                
>>>>>>> Stashed changes


                int useFoods6 = Random.Range(0, Foods.Length);
                pickfood6 = Foods[useFoods6];
<<<<<<< Updated upstream
                Debug.Log("This is" + useFoods6);
                Debug.Log("Order 2.3 is: " + Foods[useFoods6]);

                OrderButtonTwo.gameObject.GetComponentInChildren<Text>().text = pickfood4 + ", " + pickfood5 + ", " + pickfood6;
=======
                

                OrderButtonTwo.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = pickfood4 + ", " + pickfood5 + ", " + pickfood6 + ", " + PlanetOutcome2.name;
>>>>>>> Stashed changes
                //menuButton2.gameObject.gameObject.GetComponentInChildren<Text>().text = pickfood4 + ", " + pickfood5 + ", " + pickfood6;

                orderStatus.text = "Order Picked Up.";
            }
            if (count == 2)
            {
           

                System.Random random6 = new System.Random();

                int useFoods7 = Random.Range(0, Foods.Length);
                pickfood7 = Foods3[useFoods7];


                int useFoods8 = Random.Range(0, Foods.Length);
                pickfood8 = Foods3[useFoods8];


                int useFoods9 = Random.Range(0, Foods.Length);
                pickfood9 = Foods3[useFoods9];

                OrderButtonThree.gameObject.GetComponentInChildren<Text>().text = pickfood7 + ", " + pickfood8 + ", " + pickfood9;
                //menuButton3.gameObject.gameObject.GetComponentInChildren<Text>().text = pickfood7 + ", " + pickfood8 + ", " + pickfood9;

                orderStatus.text = "Order Picked Up.";
<<<<<<< Updated upstream
            } 
        }

    }     

}

   


=======
            }
        }

    }

}
>>>>>>> Stashed changes
