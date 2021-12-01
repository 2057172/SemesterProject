using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class OrderManager : MonoBehaviour
{
   // public WindowQuestPointer pointer;

    public bool currentlyHasOrder;
    public bool currentlyOnOrder;
    public bool BurgerAndFriesB, IceCreamB, SandwichB, pizzaB;

    public Transform pickUpZone;

    public Image Menu;
    public float totalCommision;

    public GameManager gm;
    public TextMeshProUGUI OrderMoneyTXT, orderStatus, countdownTimerText;

    public float countDown;
    public float ETA;

    public menu_Items MI;


    void Start()
    {
        currentlyHasOrder = false;
        OrderMoneyTXT.gameObject.SetActive(false);
        BurgerAndFriesB = false;
        IceCreamB = false;
        SandwichB = false;
        pizzaB = false;
        currentlyOnOrder = false;
        orderStatus.text = "";
    }

    public void Update()
    {
        if(currentlyOnOrder == true)
        {

            countDown =  ETA += 1 * Time.deltaTime;
           // Debug.Log(Mathf.Round(countDown));

            countDown =  ETA -= 1 * Time.deltaTime;
            Debug.Log(Mathf.RoundToInt(countDown));
            countdownTimerText.text = countDown.ToString();
 
        } 
    }
}
