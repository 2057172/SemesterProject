using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerOrderInfo : MonoBehaviour
{
    public Image Menu;
    public WindowQuestPointer pointer;
    public OrderManager orderManager;

    void Start()
    {
        Menu.gameObject.SetActive(false);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "PickupZone")
        {
            Menu.gameObject.SetActive(true);
        }

        if(collision.gameObject.tag == "DropOffZone" && orderManager.currentlyHasOrder == true)
        {
            pointer.gameObject.SetActive(false);
            orderManager.currentlyHasOrder = false;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PickupZone")
        {
            Menu.gameObject.SetActive(false);
        }
    }

    
}
