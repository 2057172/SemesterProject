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

    public PlayerOrderInfo PI;

    public GameObject player, planet1, planet2;

    public Button b1, b2, b3, b4, b5, b6;

    public void Update()
    {
        Distance1TXT.text = Mathf.RoundToInt(Vector2.Distance(player.gameObject.GetComponent<Transform>().position,
            MI.PlanetOutcome1.gameObject.GetComponent<Transform>().position)).ToString() + "km";

        Distance2TXT.text = Mathf.RoundToInt(Vector2.Distance(player.gameObject.GetComponent<Transform>().position,
            MI.PlanetOutcome2.gameObject.GetComponent<Transform>().position)).ToString() + "km";
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
        } b1.interactable = false;
    }
    public void onButton2()
    {
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
        b2.interactable = false;
    }
    public void onButton3()
    {
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
        b3.interactable = false;
    }
    public void onButton4()
    {
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
        b5.interactable = false;
    }
    public void onButton6()
    {
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
        b6.interactable = false;
    }

    public void Confirm()
    {
        buttonScript.OrderPanel.SetActive(false);
        PI.Menu.gameObject.SetActive(false);

        //planetScript.fillOrders();
        correctOrderSelected1 = false;
        correctOrderSelected2 = false;

        Planet1.gameObject.SetActive(true);
        Planet2.gameObject.SetActive(true);

        Distance1TXT.gameObject.SetActive(true);
        Distance2TXT.gameObject.SetActive(true);

        Distance1TXT.text = Mathf.RoundToInt(Vector2.Distance(player.gameObject.GetComponent<Transform>().position,
            MI.PlanetOutcome1.gameObject.GetComponent<Transform>().position)).ToString() + "m";

        Distance2TXT.text = Mathf.RoundToInt(Vector2.Distance(player.gameObject.GetComponent<Transform>().position,
            MI.PlanetOutcome2.gameObject.GetComponent<Transform>().position)).ToString() + "m";

        Planet1.GetComponent<TextMeshProUGUI>().text = MI.PlanetOutcome1.name;
        Planet2.GetComponent<TextMeshProUGUI>().text = MI.PlanetOutcome2.name;

        PI.destination1 = MI.PlanetOutcome1.name;
        PI.destination2 = MI.PlanetOutcome2.name;
    }


}
