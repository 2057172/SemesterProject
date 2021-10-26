using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderManager : MonoBehaviour
{
    public WindowQuestPointer pointer;

    public bool currentlyHasOrder;
    public bool currentlyOnOrder;
    public bool BurgerAndFriesB, IceCreamB, SandwichB;

    public Transform pickUpZone;
    public Transform BAndFriesDestination;

    public Transform BurgerAndFriedDropoff;

    public Image Menu;
    public float totalCommision;

    public GameManager gm;
    public Text OrderMoneyTXT;

    public float countDown;
    public float ETA;


    void Start()
    {
        currentlyHasOrder = false;
        OrderMoneyTXT.gameObject.SetActive(false);
        BurgerAndFriesB = false;
        IceCreamB = false;
        SandwichB = false;
        currentlyOnOrder = false;
    }

    public void Update()
    {
        if(currentlyOnOrder == true)
        {
            countDown =  ETA -= 1 * Time.deltaTime;
            Debug.Log(Mathf.Round(countDown));
        } 
    }


    public void BurgerAndFries()
    {
        if (gm.money >= 20)
        {
            gm.money = gm.money - 20;
            currentlyHasOrder = true;
            BurgerAndFriesB = true;
            pointer.targetPosition = BurgerAndFriedDropoff.position;
            Menu.gameObject.SetActive(false);
            totalCommision = 20 + (Vector3.Distance(pickUpZone.position, BAndFriesDestination.position) * 0.8f);
            OrderMoneyTXT.text = "Total: $" + Mathf.Round(totalCommision);
            OrderMoneyTXT.gameObject.SetActive(true);           
        }
        else { Debug.Log("Can't Afford"); }
    }
}
