using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class buttonLogic : MonoBehaviour
{

    public RandomIncorrectOrder buttonScript;
    public NewRandomPlanets planetScript;
    public menu_Items MI;

    public bool correctOrderSelected1, correctOrderSelected2;
    public TextMeshProUGUI Distance1TXT, Distance2TXT, Distance3TXT, Planet1, Planet2, Planet3;

    public GameObject player, planet1, planet2;

    public Button b1, b2, b3, b4, b5, b6;

    public void Update()
    {
        Distance1TXT.text = Mathf.RoundToInt(Vector2.Distance(player.gameObject.GetComponent<Transform>().position,
            MI.PlanetOutcome1.gameObject.GetComponent<Transform>().position)).ToString() + "m";

        Distance2TXT.text = Mathf.RoundToInt(Vector2.Distance(player.gameObject.GetComponent<Transform>().position,
            MI.PlanetOutcome2.gameObject.GetComponent<Transform>().position)).ToString() + "m";
    }
    public void onButton1()
    {
        if(buttonScript.CorrectButton1 == true)
        {
            if(correctOrderSelected1 == false)
            {
                correctOrderSelected1 = true;
            }else
            {
                correctOrderSelected2 = true;
            }
            
        }
        b1.interactable = false;
    }
    public void onButton2()
    {
        b2.interactable = false;
        if (buttonScript.CorrectButton2 == true)
        {
            if (correctOrderSelected1 == false)
            {
                correctOrderSelected1 = true;
            }
            else
            {
                correctOrderSelected2 = true;
            }
        }
        
    }
    public void onButton3()
    {
        b3.interactable = false;
        if (buttonScript.CorrectButton3 == true)
        {
            if (correctOrderSelected1 == false)
            {
                correctOrderSelected1 = true;
            }
            else
            {
                correctOrderSelected2 = true;
            }
        }
        
    }
    public void onButton4()
    {
        b4.interactable = false;
        if (buttonScript.CorrectButton4 == true)
        {
            if (correctOrderSelected1 == false)
            {
                correctOrderSelected1 = true;
            }
            else
            {
                correctOrderSelected2 = true;
            }
        }
        b4.interactable = false;
    }
    public void onButton5()
    {
        b5.interactable = false;
        if (buttonScript.CorrectButton5 == true)
        {
            if (correctOrderSelected1 == false)
            {
                correctOrderSelected1 = true;
            }
            else
            {
                correctOrderSelected2 = true;
            }
        }
        
    }
    public void onButton6()
    {
        b6.interactable = false;
        if (buttonScript.CorrectButton6 == true)
        {
            if (correctOrderSelected1 == false)
            {
                correctOrderSelected1 = true;
            }
            else
            {
                correctOrderSelected2 = true;
            }
        }
        
    }

    public void Confirm()
    {
        buttonScript.OrderPanel.SetActive(false);

        //planetScript.fillOrders();
        correctOrderSelected1 = false;
        correctOrderSelected2 = false;

        Distance1TXT.gameObject.SetActive(true);
        Distance2TXT.gameObject.SetActive(true);

        Planet1.gameObject.SetActive(true);
        Planet2.gameObject.SetActive(true);

        Distance1TXT.text = Mathf.RoundToInt(Vector2.Distance(player.gameObject.GetComponent<Transform>().position,
            MI.PlanetOutcome1.gameObject.GetComponent<Transform>().position)).ToString() + "m";

        Distance2TXT.text = Mathf.RoundToInt(Vector2.Distance(player.gameObject.GetComponent<Transform>().position,
            MI.PlanetOutcome2.gameObject.GetComponent<Transform>().position)).ToString() + "m";


        Planet1.GetComponent<TextMeshProUGUI>().text = MI.PlanetOutcome1.name;
        planet2.GetComponent<TextMeshProUGUI>().text = MI.PlanetOutcome2.name;
    }


}
