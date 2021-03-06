using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class menu_Items : MonoBehaviour

{
    public GameObject[] Planets = new GameObject[14];
    public GameObject PlanetOutcome1, PlanetOutcome2, PlanetOutcome3, planet1Final, planet2Final, planet3Final;
    public float Distance1, Distance2, Distance3;
    public Vector3 Destination1, Destination2, Destination3;

    public TextMeshProUGUI Distance1TXT, Distance2TXT, Distance3TXT, Planet1, Planet2, Planet3;


    public GameManager gm;
    public Button OrderButtonOne, OrderButtonTwo, OrderButtonThree;
    public NewRandomPlanets newRandomPlanets;

    public UpgradeShop upgradeShop;

    public buttonLogic bl;

    public TextMeshProUGUI orderStatus;
    public bool OnOrder1, onOrder2;



    //IMAGE STUFF
    public Sprite burgerImg;
    public Sprite steakImg;
    public Sprite ribsImg;
    public Sprite tacoImg;
    public Sprite noodlesImg;
    public Sprite pizzaImg;
    public Sprite chickenImg;
    public Sprite sushiImg;
    public Sprite fishImg;
    public Sprite calamariImg;
    public Sprite prawnImg;
    public Sprite saladImg;
    public Sprite chipsImg;
    public Sprite onionRingsImg;
    public Sprite riceImg;
    public Sprite donutsImg;
    public Sprite iceCreamImg;
    public Sprite waffleImg;
    public Sprite cupcakeImg;
    public Sprite milkshakeImg;
    public Sprite waterImg;
    public Sprite juiceImg;
    public Sprite alcoholImg;
    public Sprite coldDrinkImg;

    public Sprite earthPlanet_Food;
    public Sprite junglePlanet_Food;
    public Sprite lavaPlanet_Food;
    public Sprite pillowPlanet_Food;
    public Sprite sunPlanet_Food;
    public Sprite icePlanet_Food;
    public Sprite catPlanet_Food;
    public Sprite robotPlanet_Food;
    public Sprite lsdPlanet_Food;
    public Sprite gasPlanet_Food;
    public Sprite weedPlanet_Food;
    public Sprite discoPlanet_Food;
    public Sprite bougiePlanet_Food;
    public Sprite lovecraftPlanet_Food;



    //PHONE ORDER BUTTON STUFF
    public Image phoneOrderbutton1_food1;
    public Image phoneOrderbutton1_food2;
    public Image phoneOrderbutton1_food3;


    public Image phoneOrderbutton2_food1;
    public Image phoneOrderbutton2_food2;
    public Image phoneOrderbutton2_food3;

    public Image phoneOrderbutton3_food1;
    public Image phoneOrderbutton3_food2;
    public Image phoneOrderbutton3_food3;

    //PLANET ORDER BUTTON STUFF
    public Image phoneOrderbutton1_planet;
    public Image phoneOrderbutton2_planet;

    //PLANET IMAGES
    public Sprite earthPlanetImg;
    public Sprite junglePlanetImg;
    public Sprite icePlanetImg;
    public Sprite catPlanetImg;
    public Sprite metalPlanetImg;
    public Sprite theSunPlanetImg;
    public Sprite lavaPlanetImg;
    public Sprite sleepyPlanetImg;
    public Sprite dancePlanetImg;
    public Sprite lovecraftPlanetImg;
    public Sprite lsdPlanetImg;
    public Sprite weedPlanetImg;
    public Sprite gasPlanetImg;
    public Sprite bougiePlanetImg;


    public string[] Foods = new string[]
    {
        "Cheeseburger",
        "Steak",
        "Ribs",
        "Taco",
        "Noodles",
        "Pizza",
        "Chicken Piece",
        "Sushi",
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
        "Cheeseburger",
        "Steak",
        "Ribs",
        "Taco",
        "Noodles",
        "Pizza",
        "Chicken Piece",
        "Sushi",
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
        "Cheeseburger",
        "Steak",
        "Ribs",
        "Taco",
        "Noodles",
        "Pizza",
        "Chicken Piece",
        "Sushi",
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

    public string pickfood1, pickfood2, pickfood3, pickfood4, pickfood5, pickfood6, pickfood7, pickfood8, pickfood9, pickplanet;

    public int orderCounter;

    public void Start()
    {
        getRandomPlanet();
        RefreshOrders();
        RefreshOrders();
        newRandomPlanets.fillOrders();


        OnOrder1 = false;
        onOrder2 = false;
        

        Distance1TXT.gameObject.SetActive(false);
        Distance2TXT.gameObject.SetActive(false);
        Distance3TXT.gameObject.SetActive(false);

        Planet1.gameObject.SetActive(false);
        Planet2.gameObject.SetActive(false);
        Planet3.gameObject.SetActive(false);


        //PHONE BUTTON  1 ORDER
       // gm.OrderButton1.GetComponentInChildren<TextMeshProUGUI>().text = pickfood1 + ", " + pickfood2 + ", " + pickfood3 + ", " + PlanetOutcome1.name;
        //PHONE BUTTON  2 ORDER
        //gm.OrderButton2.GetComponentInChildren<TextMeshProUGUI>().text = pickfood4 + "," + pickfood5 + "," + pickfood6 + ", " + PlanetOutcome2.name;

        orderStatus.text = "";

        //IMAGE STUFF FOR PHONE ORDER BUTTON 1 
        phoneOrderbutton1_food1.sprite = StringtoSprite(pickfood1);
        phoneOrderbutton1_food2.sprite = StringtoSprite(pickfood2);
        phoneOrderbutton1_food3.sprite = StringtoSprite(pickfood3);

        //IMAGE STUFF FOR PHONE ORDER BUTTON 2
        phoneOrderbutton2_food1.sprite = StringtoSprite(pickfood4);
        phoneOrderbutton2_food2.sprite = StringtoSprite(pickfood5);
        phoneOrderbutton2_food3.sprite = StringtoSprite(pickfood6);

    }

    public void Update()
    {
        if (orderCounter <= 0)
        {
            orderCounter = 0;
        }
       /* if (orderCounter >= upgradeShop.maxOrderCapacity)
        {
            orderCounter = upgradeShop.maxOrderCapacity;
        }*/


        //PLANET BUTTON STUFF
        orderButton1Planet();
       // Debug.Log("1" + PlanetOutcome1);
        orderButton2Planet();
       // Debug.Log("2" + PlanetOutcome2);
    }

    public void getRandomPlanet()
    {
        for (int count = 0; count < 3; count++)
        {
            if (count == 0)
            {
                PlanetOutcome1 = Planets[Random.Range(0, Planets.Length)];
                Debug.Log(PlanetOutcome1.ToString());
            }
            else if (count == 1)
            {
                PlanetOutcome2 = Planets[Random.Range(0, Planets.Length)];
                Debug.Log(PlanetOutcome2.ToString());
            }
            else if (count == 2)
            {
                PlanetOutcome3 = Planets[Random.Range(0, Planets.Length)];
                Debug.Log(gameObject.name);
            }

        }
    }

    public void Order1()
    {
        if (OnOrder1 == false)
        {
            OrderButtonOne.gameObject.SetActive(false);
            OnOrder1 = true;
            orderCounter++;
            planet1Final = PlanetOutcome1;
            bl.planet1 = PlanetOutcome1;
        }
    }
    public void Order2()
    {
        if (onOrder2 == false)
        {
            OrderButtonTwo.gameObject.SetActive(false);
            onOrder2 = true;
            orderCounter++;
            planet2Final = PlanetOutcome2;
            bl.planet2 = PlanetOutcome2;
        }
    }


    public void RefreshOrders()
    {
        for (int count = 0; count < 3; count++)
        {
            //Debug.Log(count);

            if (count == 0)
            {

                System.Random random1 = new System.Random();

                int useFoods1 = Random.Range(0, Foods.Length);
                pickfood1 = Foods[useFoods1];
                //Debug.Log("This is" + useFoods1);


                int useFoods2 = Random.Range(0, Foods.Length);
                pickfood2 = Foods[useFoods2];
                //Debug.Log("This is" + useFoods2);

                int useFoods3 = Random.Range(0, Foods.Length);
                pickfood3 = Foods[useFoods3];
                //Debug.Log("This is" + useFoods3);

                //OrderButtonOne.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = pickfood1 + ", " + pickfood2 + ", " + pickfood3 + ", " + newRandomPlanets.PlanetOutcome1;

                //IMAGE STUFF FOR PHONE ORDER BUTTON 1 
                phoneOrderbutton1_food1.sprite = StringtoSprite(pickfood1);
                phoneOrderbutton1_food2.sprite = StringtoSprite(pickfood2);
                phoneOrderbutton1_food3.sprite = StringtoSprite(pickfood3);



                orderStatus.text = "Order Picked Up.";
            }
            if (count == 1)
            {


                System.Random random4 = new System.Random();
                int random4New = Random.Range(0, Foods.Length);

                int useFoods4 = Random.Range(0, Foods.Length);
                pickfood4 = Foods[useFoods4];
                //Debug.Log("This is" + random4New);
                //Debug.Log("Order 2.1 is: " + Foods[useFoods4]);


                int useFoods5 = Random.Range(0, Foods.Length);
                pickfood5 = Foods[useFoods5];
                //Debug.Log("This is" + useFoods5);
                //Debug.Log("Order 2.2 is: " + Foods[useFoods5]);


                int useFoods6 = Random.Range(0, Foods.Length);
                pickfood6 = Foods[useFoods6];
                //Debug.Log("This is" + useFoods6);
                //Debug.Log("Order 2.3 is: " + Foods[useFoods6]);

               // OrderButtonTwo.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = pickfood4 + ", " + pickfood5 + ", " + pickfood6;
                //IMAGE STUFF FOR PHONE ORDER BUTTON 2
                phoneOrderbutton2_food1.sprite = StringtoSprite(pickfood4);
                phoneOrderbutton2_food2.sprite = StringtoSprite(pickfood5);
                phoneOrderbutton2_food3.sprite = StringtoSprite(pickfood6);

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

                OrderButtonThree.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = pickfood7 + ", " + pickfood8 + ", " + pickfood9;
                //menuButton3.gameObject.gameObject.GetComponentInChildren<Text>().text = pickfood7 + ", " + pickfood8 + ", " + pickfood9;

                orderStatus.text = "Order Picked Up.";
            }
        }

    }

    //SPRITE STUFF
    public Sprite StringtoSprite(string s)
    {
        switch (s)
        {
            case "Cheeseburger":
                return burgerImg;
                break;

            case "Steak":
                return steakImg;
                break;

            case "Ribs":
                return ribsImg;
                break;

            case "Taco":
                return tacoImg;
                break;

            case "Noodles":
                return noodlesImg;
                break;

            case "Pizza":
                return pizzaImg;
                break;

            case "Chicken Piece":
                return chickenImg;
                break;

            case "Sushi":
                return sushiImg;
                break;

            case "Fried Fish":
                return fishImg;
                break;

            case "Fried Calamari":
                return calamariImg;
                break;

            case "Fried Prawns":
                return prawnImg;
                break;


            case "Salad":
                return saladImg;
                break;

            case "Chips":
                return chipsImg;
                break;

            case "Onion Rings":
                return onionRingsImg;
                break;

            case "Rice":
                return riceImg;
                break;

            case "Doughnuts":
                return donutsImg;
                break;

            case "Waffles":
                return waffleImg;
                break;

            case "Cupcakes":
                return cupcakeImg;
                break;

            case "Ice Cream":
                return iceCreamImg;
                break;

            case "Milkshake":
                return milkshakeImg;
                break;

            case "Water":
                return waterImg;
                break;

            case "Juice":
                return juiceImg;
                break;

            case "Alchol":
                return alcoholImg;
                break;

            case "Cold Drink":
                return coldDrinkImg;
                break;

            //////////////////////

            case "Human Food":
                return earthPlanet_Food;
                break;

            case "Bugs":
                return junglePlanet_Food;
                break;

            case "Lava Drink":
                return lavaPlanet_Food;
                break;

            case "Warm Milk":
                return pillowPlanet_Food;
                break;

            case "Sun food":
                return sunPlanet_Food;
                break;

            case "Snow cone":
                return icePlanet_Food;
                break;

            case "Cat food":
                return catPlanet_Food;
                break;

            case "Nuts and Bolts":
                return robotPlanet_Food;
                break;

            case "Space Shrooms":
                return lsdPlanet_Food;
                break;

            case "Helium":
                return gasPlanet_Food;
                break;

            case "Energy Drink":
                return discoPlanet_Food;
                break;


            case "Joint":
                return weedPlanet_Food;
                break;

            case "Diamond Caviar":
                return bougiePlanet_Food;
                break;

            case "THE VOID":
                return lovecraftPlanet_Food;
                break;


            default:
                Debug.Log("incorrect string");
                return null;
                break;
        }
        return null;




    }
















    public void orderButton1Planet()
    {
        Debug.Log("Choose random planet + set image");
        //ORDER BUTTON STUFF 
        if (PlanetOutcome1.name == "Forest Planet")
        {
            phoneOrderbutton1_planet.sprite = junglePlanetImg;
        }

        if (PlanetOutcome1.name == "Earth Planet")
        {
            phoneOrderbutton1_planet.sprite = earthPlanetImg;
        }

        if (PlanetOutcome1.name == "Ice Planet")
        {
            phoneOrderbutton1_planet.sprite = icePlanetImg;
        }
        if (PlanetOutcome1.name == "Metal Planet")
        {
            phoneOrderbutton1_planet.sprite = metalPlanetImg;
        }

        if (PlanetOutcome1.name == "Cat Planet")
        {
            phoneOrderbutton1_planet.sprite = catPlanetImg;
        }

        if (PlanetOutcome1.name == "The Sun Planet")
        {
            phoneOrderbutton1_planet.sprite = theSunPlanetImg;
        }

        if (PlanetOutcome1.name == "Sleepy Planet")
        {
            phoneOrderbutton1_planet.sprite = sleepyPlanetImg;
        }

        if (PlanetOutcome1.name == "FIre/Lava Planet")
        {
            phoneOrderbutton1_planet.sprite = lavaPlanetImg;
        }

        if (PlanetOutcome1.name == "Dance Party Planet")
        {
            phoneOrderbutton1_planet.sprite = dancePlanetImg;
        }


        if (PlanetOutcome1.name == "Lovecraft Planet")
        {
            phoneOrderbutton1_planet.sprite = lovecraftPlanetImg;
        }

        if (PlanetOutcome1.name == "LSD Planet")
        {
            phoneOrderbutton1_planet.sprite = lsdPlanetImg;
        }

        if (PlanetOutcome1.name == "Weed Planet")
        {
            phoneOrderbutton1_planet.sprite = weedPlanetImg;
        }

        if (PlanetOutcome1.name == "Bougie Planet")
        {
            phoneOrderbutton1_planet.sprite = bougiePlanetImg;
        }

        if (PlanetOutcome1.name == "Gas Planet")
        {
            phoneOrderbutton1_planet.sprite = gasPlanetImg;

        }
    }

    public void orderButton2Planet()
    {
        
         //ORDER BUTTON STUFF 
         if (PlanetOutcome2.name == "Forest Planet")
         {
             phoneOrderbutton2_planet.sprite = junglePlanetImg;
         }

         if (PlanetOutcome2.name == "Earth Planet")
         {
             phoneOrderbutton2_planet.sprite = earthPlanetImg;
         }

         if (PlanetOutcome2.name == "Ice Planet")
         {
             phoneOrderbutton2_planet.sprite = icePlanetImg;
         }
         if (PlanetOutcome2.name == "Metal Planet")
         {
             phoneOrderbutton2_planet.sprite = metalPlanetImg;
         }

         if (PlanetOutcome2.name == "Cat Planet")
         {
             phoneOrderbutton2_planet.sprite = catPlanetImg;
         }

         if (PlanetOutcome2.name == "The Sun Planet")
         {
             phoneOrderbutton2_planet.sprite = theSunPlanetImg;
         }

         if (PlanetOutcome2.name == "Sleepy Planet")
         {
             phoneOrderbutton2_planet.sprite = sleepyPlanetImg;
         }

         if (PlanetOutcome2.name == "FIre/Lava Planet")
         {
             phoneOrderbutton2_planet.sprite = lavaPlanetImg;
         }

         if (PlanetOutcome2.name == "Dance Party Planet")
         {
             phoneOrderbutton2_planet.sprite = dancePlanetImg;
         }


         if (PlanetOutcome2.name == "Lovecraft Planet")
         {
             phoneOrderbutton2_planet.sprite = lovecraftPlanetImg;
         }

         if (PlanetOutcome2.name == "LSD Planet")
         {
             phoneOrderbutton2_planet.sprite = lsdPlanetImg;
         }

         if (PlanetOutcome2.name == "Weed Planet")
         {
             phoneOrderbutton2_planet.sprite = weedPlanetImg;
         }

         if (PlanetOutcome2.name == "Bougie Planet")
         {
             phoneOrderbutton2_planet.sprite = bougiePlanetImg;
         }

         if (PlanetOutcome2.name == "Gas Planet")
         {
             phoneOrderbutton2_planet.sprite = gasPlanetImg;
         }
     }
        


    }
