using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public float money;
    public Text moneyTXT;
    public GameObject phone;
    public bool phoneUp;

    public WindowQuestPointer pointer;

    public Button takeBurgerAndFriedOrder, takePizzaOrder, takeIceCreamOrder;
    public OrderManager om;
    public Transform pickUp;
    public GameObject Player;

    public Transform burgerAndFriesDropOff, Earth, ForestPlanet;

    public Vector3 deliveryDestination;

    public GameObject Map;
    public bool mapOpen;

    void Start()
    {
        pointer.gameObject.SetActive(false);
        //money = 20;
        phoneUp = false;
        mapOpen = false;
    }

    void Update()
    {
        moneyTXT.text = "$" + Mathf.RoundToInt(money);
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if(Input.GetKeyDown(KeyCode.M))
        {
            if(mapOpen == false)
            {
                Map.gameObject.SetActive(true);
                mapOpen = true;
            } else if(mapOpen == true)
            {
                Map.gameObject.SetActive(false);
                mapOpen = false;
            }
        }

        if(Input.GetKeyDown(KeyCode.H))
        {
            if (phoneUp == false)
            {
                phone.GetComponent<RectTransform>().anchoredPosition = new Vector2(763f, -186f);
                takeBurgerAndFriedOrder.gameObject.SetActive(true);
                takePizzaOrder.gameObject.SetActive(true);
                takeIceCreamOrder.gameObject.SetActive(true);

                //takeBurgerAndFriedOrder.GetComponentInChildren<Text>().text = "Burger and Fries: $" + Mathf.RoundToInt(20 + (Vector3.Distance(pickUp.position, om.BAndFriesDestination.position) * 0.8f));
                //takePizzaOrder.GetComponentInChildren<Text>().text = "Pizza: $" + Mathf.RoundToInt(20 + (Vector3.Distance(pickUp.position, om.PizzaDestination.position) * 0.8f));
                //takeIceCreamOrder.GetComponentInChildren<Text>().text = "IceCream: $" + Mathf.RoundToInt(20 + (Vector3.Distance(pickUp.position, om.IceCreamDestination.position) * 0.8f));
                phoneUp = true;
            }
            else if (phoneUp == true)
            {
                phone.GetComponent<RectTransform>().anchoredPosition = new Vector2(763f, -653f);
                takeBurgerAndFriedOrder.gameObject.SetActive(false);
                takePizzaOrder.gameObject.SetActive(false);
                takeIceCreamOrder.gameObject.SetActive(false);
                phoneUp = false;
            }
        } 

        
    }

    public void BurgerAndFriesOrderSelected()
    {
        //pointer.gameObject.SetActive(true);
        //pointer.targetPosition = pickUp.position;
        deliveryDestination = burgerAndFriesDropOff.position;
        //pointer.targetPosition = pickUp.position;

        om.ETA = Mathf.Round(Vector3.Distance(om.pickUpZone.position, om.BAndFriesDestination.position)) + 
            Mathf.Round(Vector3.Distance(Player.gameObject.GetComponent<Transform>().position, om.pickUpZone.position));
        om.currentlyOnOrder = true;
    }
    public void PizzaOrderSelected()
    {
        //pointer.gameObject.SetActive(true);
        //pointer.targetPosition = pickUp.position;
        deliveryDestination = Earth.position;
        //pointer.targetPosition = pickUp.position;

        om.ETA = Mathf.Round(Vector3.Distance(om.pickUpZone.position, om.PizzaDestination.position)) +
            Mathf.Round(Vector3.Distance(Player.gameObject.GetComponent<Transform>().position, om.pickUpZone.position));
        om.currentlyOnOrder = true;
    }
    public void IceCreamOrderSelected()
    {
        //pointer.gameObject.SetActive(true);
       //pointer.targetPosition = pickUp.position;
        deliveryDestination = ForestPlanet.position;
        //pointer.targetPosition = pickUp.position;

        om.ETA = Mathf.Round(Vector3.Distance(om.pickUpZone.position, om.IceCreamDestination.position)) +
            Mathf.Round(Vector3.Distance(Player.gameObject.GetComponent<Transform>().position, om.pickUpZone.position));
        om.currentlyOnOrder = true;
    }


}
