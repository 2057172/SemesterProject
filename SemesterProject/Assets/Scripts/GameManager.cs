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

    public Button takeBurgerAndFriedOrder;
    public OrderManager om;
    public Transform pickUp;

    public Transform burgerAndFriesDropOff;

    public Vector3 deliveryDestination;

    void Start()
    {
        pointer.gameObject.SetActive(false);
        //money = 20;
        phoneUp = false;
        
    }

    void Update()
    {
        moneyTXT.text = "$" + Mathf.RoundToInt(money);
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }


        if(Input.GetKeyDown(KeyCode.H))
        {
            if (phoneUp == false)
            {
                phone.GetComponent<RectTransform>().anchoredPosition = new Vector2(763f, -186f);
                takeBurgerAndFriedOrder.gameObject.SetActive(true);
                takeBurgerAndFriedOrder.GetComponentInChildren<Text>().text = "Burger and Fries: $" + Mathf.RoundToInt(20 + (Vector3.Distance(pickUp.position, om.BAndFriesDestination.position) * 0.8f));
                phoneUp = true;
            }
            else if (phoneUp == true)
            {
                phone.GetComponent<RectTransform>().anchoredPosition = new Vector2(763f, -653f);
                takeBurgerAndFriedOrder.gameObject.SetActive(false);
                phoneUp = false;
            }
        } 

        
    }

    public void BurgerAndFriesOrderSelected()
    {
        pointer.gameObject.SetActive(true);
        pointer.targetPosition = pickUp.position;
        deliveryDestination = burgerAndFriesDropOff.position;
        pointer.targetPosition = pickUp.position;
    }

    
}
