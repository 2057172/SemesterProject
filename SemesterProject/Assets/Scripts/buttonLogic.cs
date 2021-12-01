using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class buttonLogic : MonoBehaviour
{

    public RandomIncorrectOrder buttonScript;
    public NewRandomPlanets planetScript;

    public bool correctOrderSelected1, correctOrderSelected2;
    public TextMeshProUGUI Distance1TXT, Distance2TXT, Distance3TXT, Planet1, Planet2, Planet3;

    public GameObject player;

    public void Update()
    {
        Distance1TXT.text = Mathf.RoundToInt(Vector2.Distance(player.gameObject.GetComponent<Transform>().position,
            planetScript.PlanetOutcome1.gameObject.GetComponent<Transform>().position)).ToString() + "m";
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
    }

    public void Confirm()
    {
        buttonScript.OrderPanel.SetActive(false);

        //planetScript.fillOrders();
        correctOrderSelected1 = false;
        correctOrderSelected2 = false;

        Distance1TXT.gameObject.SetActive(true);

        Distance1TXT.text = Mathf.RoundToInt(Vector2.Distance(player.gameObject.GetComponent<Transform>().position,
            planetScript.PlanetOutcome1.gameObject.GetComponent<Transform>().position)).ToString() + "m";
    }


}
