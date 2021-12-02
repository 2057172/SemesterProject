using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public float money;
    public TextMeshProUGUI moneyTXT;
    public GameObject phone;
    public bool phoneUp;

    public WindowQuestPointer pointer;

    public Button OrderButton1, OrderButton2, OrderButton3, refreshButton;
    public GameObject Player;

    public Vector3 deliveryDestination;

    public GameObject Map;
    public bool mapOpen;

    public menu_Items MI;

    void Start()
    {
        //pointer.gameObject.SetActive(false);
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
                phone.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
                if(MI.OnOrder1 == false)
                {
                    OrderButton1.gameObject.SetActive(true);
                }
                if (MI.onOrder2 == false)
                {
                    OrderButton2.gameObject.SetActive(true);
                }
                if (MI.onOrder2 == false)
                {
                    OrderButton2.gameObject.SetActive(true);
                } else if (MI.OnOrder1 == true)
                {
                    OrderButton1.gameObject.SetActive(false);
                }
                else if (MI.onOrder2 == true)
                {
                    OrderButton2.gameObject.SetActive(false);
                }
                else if (MI.onOrder3 == true)
                {
                    OrderButton3.gameObject.SetActive(false);
                }

                phoneUp = true;
            }
            else if (phoneUp == true)
            {
                phone.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 424f);
                OrderButton1.gameObject.SetActive(false);
                OrderButton2.gameObject.SetActive(false);
                OrderButton3.gameObject.SetActive(false);
                refreshButton.gameObject.SetActive(false);
                phoneUp = false;
            }
        } 

        
    }
}
