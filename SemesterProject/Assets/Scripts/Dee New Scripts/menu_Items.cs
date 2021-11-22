using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class menu_Items : MonoBehaviour

{

    public GameManager gm;
    public buttonLogic BL;

    public Button OrderButtonOne, OrderButtonTwo, OrderButtonThree, menuButton1, menuButton2, menuButton3;

    public Transform Earth, Forest, Ice, Metal, Cat, Sun, Sleep, Fire, Dance, Lovecraft, LSD, Weed, Bougie, Gas;

    public TextMeshProUGUI orderStatus;
    public bool OnOrder1, onOrder2, onOrder3;

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

 
    public void Start()
    {
        RefreshOrders();
        RefreshOrders();

        OnOrder1 = false;
        onOrder2 = false;
        onOrder3 = false;
      
        gm.OrderButton1.GetComponentInChildren<Text>().text = pickfood1 + ", " + pickfood2 + ", " + pickfood3;
        gm.OrderButton2.GetComponentInChildren<Text>().text = pickfood4 + "," + pickfood5 + "," + pickfood6;

        orderStatus.text = "";
    }

    

    public void Order1()
    {
        if (OnOrder1 == false)
        {
            OrderButtonOne.gameObject.SetActive(false);
            OnOrder1 = true;
        }
    }
    public void Order2()
    {
        if (onOrder2 == false)
        {
            OrderButtonTwo.gameObject.SetActive(false);
            onOrder2 = true;
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
            Debug.Log(count);

            if (count == 0)
            {
               
                System.Random random1 = new System.Random();

                int useFoods1 = Random.Range(0, Foods.Length);
                pickfood1 = Foods[useFoods1];
                Debug.Log("This is" + useFoods1);


                int useFoods2 = Random.Range(0, Foods.Length);
                pickfood2 = Foods[useFoods2];
                Debug.Log("This is" + useFoods2);

                int useFoods3 = Random.Range(0, Foods.Length);
                pickfood3 = Foods[useFoods3];
                Debug.Log("This is" + useFoods3);

                OrderButtonOne.gameObject.GetComponentInChildren<Text>().text = pickfood1 + ", " + pickfood2 + ", " + pickfood3;
                //menuButton1.gameObject.gameObject.GetComponentInChildren<Text>().text = pickfood1 + ", " + pickfood2 + ", " + pickfood3;

                orderStatus.text = "Order Picked Up.";
            } 
            if(count == 1)
            {
               

                System.Random random4 = new System.Random();
                int random4New = Random.Range(0, Foods.Length); 

                int useFoods4 = Random.Range(0, Foods.Length);
                pickfood4 = Foods[useFoods4];
                Debug.Log("This is" + random4New);
                Debug.Log("Order 2.1 is: " + Foods[useFoods4]);


                int useFoods5 = Random.Range(0, Foods.Length);
                pickfood5 = Foods[useFoods5];
                Debug.Log("This is" + useFoods5);
                Debug.Log("Order 2.2 is: " + Foods[useFoods5]);


                int useFoods6 = Random.Range(0, Foods.Length);
                pickfood6 = Foods[useFoods6];
                Debug.Log("This is" + useFoods6);
                Debug.Log("Order 2.3 is: " + Foods[useFoods6]);

                OrderButtonTwo.gameObject.GetComponentInChildren<Text>().text = pickfood4 + ", " + pickfood5 + ", " + pickfood6;
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
            } 
        }

    }     

}

   


