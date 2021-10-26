using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class menu_Items : MonoBehaviour
{
    public GameObject menuStation_UI;
    public GameObject background_UI;
    public GameObject beefFood_UI;
    public GameObject chickenFood_UI;
    public GameObject fishFood_UI;
    public GameObject vegFood_UI;
    public GameObject sideFood_UI;
    public GameObject dessertFood_UI;
    public GameObject drinksFoodUI;
    public GameObject planetFood_UI;


    public Button singleCheeseburger;
    public Button doubleCheeseburger;
    public Button tripleCheeseburger;
    public Button steak;
    public Button ribs;
    public Button shank;
    public Button beefTaco;
    public Button beefNoodles;
    public Button beefPizza;



    //BEEF
    public string[] beefFood = new string[]
    {  
        "Single Cheeseburger", "Double Cheeseburger", "Triple Cheeseburger",
        "Steak", "Ribs" , "Shank",
        "Beef Taco", "Beef Noodles", "Beef Pizza"
    };

    //CHICKEN
    public string[] chickenFood = new string[]
   {
        "Mild Wings", "Spicy Wings", "Super Hot Wings",
        "1 Piece Chicken",  "2 Piece Chicken",  "3 Piece Chicken",
        "Chicken Taco",  "Chicken Burger",  "Chicken Pizza"
   };

    //FISH
    public string[] fishFood = new string[]
   {
        "Sushi 1", "Sushi 2", "Sushi 3",
        "Fried Fish",  "Fried Calamari",  "Fried Prawn",
        "Fish Curry",  "Fish Noodles" ,   "Fish Pizza"
   };

    //VEG
    public string[] vegFood = new string[]
   {
        "Salad 1", "Salad 2",  "Salad 3",
        "Veg Burger",  "Veg Tofu",  "Veg Curry",
        "Veg Taco", "Veg Burger",  "Veg Pizza"
   };


    //SIDES
    public string[] sidesFood = new string[]
   {
        "Sml Chips",   "Med Chips",   "Lrg Chips",
        "Sml Onion Rings", "Med Onion Rings", "Lrg Onion Rings",
        "Sml Rice", "Med Rice", "Lrg Rice"
   };

    //DESSERT 
    public string[] dessertFood = new string[]
   {
        "Doughnuts", "Frozen Yoghurt", "Cookies",
        "Ice cream", "Milkshake", "Waffles",
        "Cupcakes", "Pancakes",  "Cake"
   };

    //DRINKS
    public string[] drinkFood = new string[]
   {
        "Water", "Juice 1",  "Juice 2",
        "Alcohol 1",  "Alcohol 2" , "Alcohol 3",
        "Cold drink 1", "Cold drink 2", "Cold drink 3"
   };


    //PLANETS
    public string[] planetFood = new string[]
   {
        "Planet1", "Planet2",  "Planet3",
        "Planet4",  "Planet5" , "Planet6",
        "Planet7", "Planet8", "Planet9"
   };








    void Start()
    {
        menuStation_UI.SetActive(false);
        background_UI.SetActive(false);
        beefFood_UI.SetActive(false);
        chickenFood_UI.SetActive(false);
        fishFood_UI.SetActive(false);
        vegFood_UI.SetActive(false);
        sideFood_UI.SetActive(false);
        dessertFood_UI.SetActive(false);
        drinksFoodUI.SetActive(false);
        planetFood_UI.SetActive(false);

        
}


    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject.tag == "MenuStation")
        {
            if (collision.gameObject.name == "Player")
            {

                menuStation_UI.SetActive(true);
                background_UI.SetActive(true);
                beefFood_UI.SetActive(true);

            }
        }


       

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (this.gameObject.tag == "MenuStation")
        {
            if (collision.gameObject.name == "Player")
            {

                menuStation_UI.SetActive(false);
            }
        }

       
    }



    public void singleCheeseBurgerBtn()
    {
        singleCheeseburger.interactable = false; 
    }

    public void doubleCheeseburgerBtn()
    {
        doubleCheeseburger.interactable = false;
    }

    public void tripleCheeseburgerBtn()
    {
        tripleCheeseburger.interactable = false;
    }


    public void steakBtn()
    {
        steak.interactable = false;
    }

    public void ribsBtn()
    {
        ribs.interactable = false;
    }

    public void shankBtn()
    {
        shank.interactable = false; 
    }

    public void beefTacoBtn()
    {
        beefTaco.interactable = false;
    }

    public void beefNoodlesBtn()
    {
        beefNoodles.interactable = false;
    }

    public void beefPizzaBtn()
    {
        beefPizza.interactable = false;
    }
}
