using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomIncorrectOrder : MonoBehaviour
{
    public Button Order1;
    public Button Order2;
    public Button Order3;
    public Button Order4;
    public Button Order5;
    public Button Order6;
    public Button confirm;

    public bool CorrectButton1, CorrectButton2, CorrectButton3, CorrectButton4, CorrectButton5, CorrectButton6;
    public bool order1Assigned, order2Assigned, order3Assigned, order4Assigned, order5Assigned;

    public menu_Items menuItems;
    public UpgradeShop upgradeShop;



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


    //ORDER BUTTON STUFF
    public Image orderbutton1_food1;
    public Image orderbutton1_food2;
    public Image orderbutton1_food3;

    public Image orderbutton2_food1;
    public Image orderbutton2_food2;
    public Image orderbutton2_food3;

    public Image orderbutton3_food1;
    public Image orderbutton3_food2;
    public Image orderbutton3_food3;

    public Image orderbutton4_food1;
    public Image orderbutton4_food2;
    public Image orderbutton4_food3;

    public Image orderbutton5_food1;
    public Image orderbutton5_food2;
    public Image orderbutton5_food3;


    public Image orderbutton6_food1;
    public Image orderbutton6_food2;
    public Image orderbutton6_food3;

    public string[] RandomFoods = new string[]
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


    public string PickRandomFood1, PickRandomFood2, PickRandomFood3, PickRandomFood4, PickRandomFood5, PickRandomFood6, PickRandomFood7, PickRandomFood8, PickRandomFood9, PickRandomFood10, PickRandomFood11, PickRandomFood12, PickRandomFood13, PickRandomFood14,
                  PickRandomFood15, PickRandomFood16, PickRandomFood17, PickRandomFood18;

    public GameObject OrderPanel;
    // Start is called before the first frame update
    void Start()
    {
        OrderPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            OrderPanel.SetActive(true);
            AssignAllButtons();
            PickRandomFoodOrder();
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            OrderPanel.SetActive(false);
            CorrectButton1 = false;
            CorrectButton2 = false;
            CorrectButton3 = false;
            CorrectButton4 = false; 
            CorrectButton5 = false;
            CorrectButton6 = false;

            order1Assigned = false;
            order2Assigned = false;
            order3Assigned = false;
            order4Assigned = false;
            order5Assigned = false;
        }
    }

    public void PickRandomFoodOrder()
    {
            

        for (int counrt = 0; counrt < 6; counrt++)
        {
            if (counrt == 0) {
                if (CorrectButton1 == true)
                {
                    if (order1Assigned == false)
                    {
                        Order1.gameObject.GetComponentInChildren<Text>().text = menuItems.pickfood1 + ", " +
                        menuItems.pickfood2 + ", " + menuItems.pickfood3;
                        order1Assigned = true;

                        //CORRECT BUTTON 1
                        orderbutton1_food1.sprite = StringtoSprite(menuItems.pickfood1);
                        orderbutton1_food2.sprite = StringtoSprite(menuItems.pickfood2);
                        orderbutton1_food3.sprite = StringtoSprite(menuItems.pickfood3);
                    }
                    else if (order2Assigned == false)
                    {
                        Order1.gameObject.GetComponentInChildren<Text>().text = menuItems.pickfood4 + ", " +
                        menuItems.pickfood5 + ", " + menuItems.pickfood6;
                        order2Assigned = true;

                        //CORRECT BUTTON 1
                        orderbutton1_food1.sprite = StringtoSprite(menuItems.pickfood4);
                        orderbutton1_food2.sprite = StringtoSprite(menuItems.pickfood5);
                        orderbutton1_food3.sprite = StringtoSprite(menuItems.pickfood6);
                    }

                } else 
                {
                    FourRandomFoods();
                    Order1.gameObject.GetComponentInChildren<Text>().text = PickRandomFood1 + "," + PickRandomFood2 + "," + PickRandomFood3;

                    //RANDOM ORDER BUTTON 1 FOOD
                    orderbutton1_food1.sprite = StringtoSprite(PickRandomFood1);
                    orderbutton1_food2.sprite = StringtoSprite(PickRandomFood2);
                    orderbutton1_food3.sprite = StringtoSprite(PickRandomFood3);
                }               
            }
           
            if (counrt == 1)
            {
                if (CorrectButton2 == true)
                {
                    if (order1Assigned == false)
                    {
                        Order2.gameObject.GetComponentInChildren<Text>().text = menuItems.pickfood1 + ", " +
                        menuItems.pickfood2 + ", " + menuItems.pickfood3;
                        order1Assigned = true;

                        //CORRECT BUTTON 2
                        orderbutton2_food1.sprite = StringtoSprite(menuItems.pickfood1);
                        orderbutton2_food2.sprite = StringtoSprite(menuItems.pickfood2);
                        orderbutton2_food3.sprite = StringtoSprite(menuItems.pickfood3);
                    }
                    else if (order2Assigned == false)
                    {
                        Order2.gameObject.GetComponentInChildren<Text>().text = menuItems.pickfood4 + ", " +
                        menuItems.pickfood5 + ", " + menuItems.pickfood6;
                        order2Assigned = true;


                        //CORRECT BUTTON 2
                        orderbutton2_food1.sprite = StringtoSprite(menuItems.pickfood4);
                        orderbutton2_food2.sprite = StringtoSprite(menuItems.pickfood5);
                        orderbutton2_food3.sprite = StringtoSprite(menuItems.pickfood6);
                    }
                }
                else
                {
                    FourRandomFoods();
                    Order2.gameObject.GetComponentInChildren<Text>().text = PickRandomFood4 + "," + PickRandomFood5 + "," + PickRandomFood6;

                    //RANDOM ORDER BUTTON 2 FOOD
                    orderbutton2_food1.sprite = StringtoSprite(PickRandomFood4);
                    orderbutton2_food2.sprite = StringtoSprite(PickRandomFood5);
                    orderbutton2_food3.sprite = StringtoSprite(PickRandomFood6);
                }
            }
            if (counrt == 2)
            {
                if (CorrectButton3 == true)
                {
                    if(order1Assigned == false) {
                        Order3.gameObject.GetComponentInChildren<Text>().text = menuItems.pickfood1 + ", " +
                        menuItems.pickfood2 + ", " + menuItems.pickfood3;
                        order1Assigned = true;


                        //CORRECT BUTTON 3
                        orderbutton3_food1.sprite = StringtoSprite(menuItems.pickfood1);
                        orderbutton3_food2.sprite = StringtoSprite(menuItems.pickfood2);
                        orderbutton3_food3.sprite = StringtoSprite(menuItems.pickfood3);

                    } else if (order2Assigned == false)
                    {
                        Order3.gameObject.GetComponentInChildren<Text>().text = menuItems.pickfood4 + ", " +
                        menuItems.pickfood5 + ", " + menuItems.pickfood6;
                        order2Assigned = true;

                        //CORRECT BUTTON 3
                        orderbutton3_food1.sprite = StringtoSprite(menuItems.pickfood4);
                        orderbutton3_food2.sprite = StringtoSprite(menuItems.pickfood5);
                        orderbutton3_food3.sprite = StringtoSprite(menuItems.pickfood6);
                    }
                 
                }
                else
                {
                    FourRandomFoods();
                    Order3.gameObject.GetComponentInChildren<Text>().text = PickRandomFood7 + "," + PickRandomFood8 + "," + PickRandomFood9;

                    //RANDOM ORDER BUTTON 3 FOOD
                    orderbutton3_food1.sprite = StringtoSprite(PickRandomFood7);
                    orderbutton3_food2.sprite = StringtoSprite(PickRandomFood8);
                    orderbutton3_food3.sprite = StringtoSprite(PickRandomFood9);

                }
            }
            if (counrt == 3)
            {
                if (CorrectButton4 == true)
                {
                    if (order1Assigned == false)
                    {
                        Order4.gameObject.GetComponentInChildren<Text>().text = menuItems.pickfood1 + ", " +
                        menuItems.pickfood2 + ", " + menuItems.pickfood3;
                        order1Assigned = true;

                        //CORRECT BUTTON 4
                        orderbutton4_food1.sprite = StringtoSprite(menuItems.pickfood1);
                        orderbutton4_food2.sprite = StringtoSprite(menuItems.pickfood2);
                        orderbutton4_food3.sprite = StringtoSprite(menuItems.pickfood3);
                    }
                    else if (order2Assigned == false)
                    {
                        Order4.gameObject.GetComponentInChildren<Text>().text = menuItems.pickfood4 + ", " +
                        menuItems.pickfood5 + ", " + menuItems.pickfood6;
                        order2Assigned = true;

                        //CORRECT BUTTON 4
                        orderbutton3_food1.sprite = StringtoSprite(menuItems.pickfood4);
                        orderbutton3_food2.sprite = StringtoSprite(menuItems.pickfood5);
                        orderbutton3_food3.sprite = StringtoSprite(menuItems.pickfood6);
                    }
                }
                else
                {
                    FourRandomFoods();
                    Order4.gameObject.GetComponentInChildren<Text>().text = PickRandomFood10 + "," + PickRandomFood11 + "," + PickRandomFood12;

                    //RANDOM ORDER BUTTON 4 FOOD
                    orderbutton4_food1.sprite = StringtoSprite(PickRandomFood10);
                    orderbutton4_food2.sprite = StringtoSprite(PickRandomFood11);
                    orderbutton4_food3.sprite = StringtoSprite(PickRandomFood12);
                }
            }
            if (counrt == 4)
            {
                if (CorrectButton5 == true)
                {
                    if (order1Assigned == false)
                    {
                        Order5.gameObject.GetComponentInChildren<Text>().text = menuItems.pickfood1 + ", " +
                        menuItems.pickfood2 + ", " + menuItems.pickfood3;
                        order1Assigned = true;

                        //CORRECT BUTTON 5
                        orderbutton5_food1.sprite = StringtoSprite(menuItems.pickfood1);
                        orderbutton5_food2.sprite = StringtoSprite(menuItems.pickfood2);
                        orderbutton5_food3.sprite = StringtoSprite(menuItems.pickfood3);
                    }
                    else if (order2Assigned == false)
                    {
                        Order5.gameObject.GetComponentInChildren<Text>().text = menuItems.pickfood4 + ", " +
                        menuItems.pickfood5 + ", " + menuItems.pickfood6;
                        order2Assigned = true;

                        //CORRECT BUTTON 5
                        orderbutton5_food1.sprite = StringtoSprite(menuItems.pickfood4);
                        orderbutton5_food2.sprite = StringtoSprite(menuItems.pickfood5);
                        orderbutton5_food3.sprite = StringtoSprite(menuItems.pickfood6);
                    }
                }
                else
                {
                    FourRandomFoods();
                    Order5.gameObject.GetComponentInChildren<Text>().text = PickRandomFood13 + "," + PickRandomFood14 + "," + PickRandomFood15;

                    //RANDOM ORDER BUTTON 5 FOOD
                    orderbutton5_food1.sprite = StringtoSprite(PickRandomFood13);
                    orderbutton5_food2.sprite = StringtoSprite(PickRandomFood14);
                    orderbutton5_food3.sprite = StringtoSprite(PickRandomFood15);
                }
            }
            if (counrt == 5)
            {
                if (CorrectButton6 == true)
                {
                    if (order1Assigned == false)
                    {
                        Order6.gameObject.GetComponentInChildren<Text>().text = menuItems.pickfood1 + ", " +
                        menuItems.pickfood2 + ", " + menuItems.pickfood3;
                        order1Assigned = true;

                        //CORRECT BUTTON 6
                        orderbutton6_food1.sprite = StringtoSprite(menuItems.pickfood1);
                        orderbutton6_food2.sprite = StringtoSprite(menuItems.pickfood2);
                        orderbutton6_food3.sprite = StringtoSprite(menuItems.pickfood3);
                    }
                    else if (order2Assigned == false)
                    {
                        Order6.gameObject.GetComponentInChildren<Text>().text = menuItems.pickfood4 + ", " +
                        menuItems.pickfood5 + ", " + menuItems.pickfood6;
                        order2Assigned = true;

                        //CORRECT BUTTON 3
                        orderbutton3_food1.sprite = StringtoSprite(menuItems.pickfood4);
                        orderbutton3_food2.sprite = StringtoSprite(menuItems.pickfood5);
                        orderbutton3_food3.sprite = StringtoSprite(menuItems.pickfood6);
                    }
                }
                else
                {
                    FourRandomFoods();
                    Order6.gameObject.GetComponentInChildren<Text>().text = PickRandomFood16 + "," + PickRandomFood17 + "," + PickRandomFood18;

                    orderbutton6_food1.sprite = StringtoSprite(PickRandomFood16);
                    orderbutton6_food2.sprite = StringtoSprite(PickRandomFood17);
                    orderbutton6_food3.sprite = StringtoSprite(PickRandomFood18);
                }

            }
        }
       
    }

    public void AssignAllButtons()
    {
        
        int range = upgradeShop.maxOrderCapacity;

        int chosen1 = Random.Range(0, 6);

        if (upgradeShop.maxOrderCapacity == 2)
        {
            
            int chosen2 = Random.Range(0, 6);

            if (chosen1 == 0)
            {
                CorrectButton1 = true;
            }
            else if (chosen1 == 1)
            {
                CorrectButton2 = true;
            }
            else if (chosen1 == 2)
            {
                CorrectButton3 = true;
            }
            else if (chosen1 == 3)
            {
                CorrectButton4 = true;
            }
            else if (chosen1 == 4)
            {
                CorrectButton5 = true;
            }
            else if (chosen1 == 5)
            {
                CorrectButton6 = true;
            }
            if (chosen2 == 0)
            {
                if(CorrectButton1 == true)
                {
                    AssignAllButtons();
                } else { CorrectButton1 = true; }
            }
            else if (chosen2 == 1)
            {
                if (CorrectButton2 == true)
                {
                    AssignAllButtons();
                }
                else { CorrectButton2 = true; }
            }
            else if (chosen2 == 2)
            {
                if (CorrectButton3 == true)
                {
                    AssignAllButtons();
                }
                else { CorrectButton3 = true; }
            }
            else if (chosen2 == 3)
            {
                if (CorrectButton4 == true)
                {
                    AssignAllButtons();
                }
                else { CorrectButton4 = true; }
            }
            else if (chosen2 == 4)
            {
                if (CorrectButton5 == true)
                {
                    AssignAllButtons();
                }
                else { CorrectButton5 = true; }
            }
            else if (chosen2 == 5)
            {
                if (CorrectButton6 == true)
                {
                    AssignAllButtons();
                }
                else { CorrectButton6 = true; }
            }

        }

    }
    public void FourRandomFoods()
    {
        System.Random random1 = new System.Random();
        int useFoods1 = Random.Range(0, RandomFoods.Length);

        PickRandomFood1 = RandomFoods[useFoods1];
        


        System.Random random2 = new System.Random();
        int useFoods2 = Random.Range(0, RandomFoods.Length);

        PickRandomFood2 = RandomFoods[useFoods2];
        

        System.Random random3 = new System.Random();
        int useFoods3 = Random.Range(0, RandomFoods.Length);

        PickRandomFood3 = RandomFoods[useFoods3];
        

        System.Random random4 = new System.Random();
        int useFoods4 = Random.Range(0, RandomFoods.Length);

        PickRandomFood4 = RandomFoods[useFoods4];
       


        System.Random random5 = new System.Random();
        int useFoods5 = Random.Range(0, RandomFoods.Length);

        PickRandomFood5 = RandomFoods[useFoods5];
        


        System.Random random6 = new System.Random();
        int useFoods6 = Random.Range(0, RandomFoods.Length);

        PickRandomFood6 = RandomFoods[useFoods6];
        


        System.Random random7 = new System.Random();
        int useFoods7 = Random.Range(0, RandomFoods.Length);

        PickRandomFood7 = RandomFoods[useFoods7];
        



        System.Random random8 = new System.Random();
        int useFoods8 = Random.Range(0, RandomFoods.Length);

        PickRandomFood8 = RandomFoods[useFoods8];
        



        System.Random random9 = new System.Random();
        int useFoods9 = Random.Range(0, RandomFoods.Length);

        PickRandomFood9 = RandomFoods[useFoods9];
        



        System.Random random10 = new System.Random();
        int useFoods10 = Random.Range(0, RandomFoods.Length);

        PickRandomFood10 = RandomFoods[useFoods10];
        




        System.Random random11= new System.Random();
        int useFoods11 = Random.Range(0, RandomFoods.Length);

        PickRandomFood11 = RandomFoods[useFoods11];
       



        System.Random random12 = new System.Random();
        int useFoods12 = Random.Range(0, RandomFoods.Length);

        PickRandomFood12 = RandomFoods[useFoods12];
       

        System.Random random13 = new System.Random();
        int useFoods13 = Random.Range(0, RandomFoods.Length);

        PickRandomFood13 = RandomFoods[useFoods13];
        

        System.Random random14 = new System.Random();
        int useFoods14 = Random.Range(0, RandomFoods.Length);

        PickRandomFood14 = RandomFoods[useFoods14];
        

        System.Random random15 = new System.Random();
        int useFoods15 = Random.Range(0, RandomFoods.Length);

        PickRandomFood15 = RandomFoods[useFoods15];
        

        System.Random random16 = new System.Random();
        int useFoods16 = Random.Range(0, RandomFoods.Length);

        PickRandomFood16 = RandomFoods[useFoods16];
        

        System.Random random17 = new System.Random();
        int useFoods17 = Random.Range(0, RandomFoods.Length);

        PickRandomFood17 = RandomFoods[useFoods17];
        

        System.Random random18 = new System.Random();
        int useFoods18 = Random.Range(0, RandomFoods.Length);

        PickRandomFood18 = RandomFoods[useFoods18];
        
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
}
