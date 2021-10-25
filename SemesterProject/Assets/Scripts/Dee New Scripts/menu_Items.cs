using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_Items : MonoBehaviour
{
    public GameObject menuStation_UI;

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

}
