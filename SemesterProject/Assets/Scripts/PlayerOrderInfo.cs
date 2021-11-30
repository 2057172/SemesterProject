using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerOrderInfo : MonoBehaviour
{
    public Image Menu;
    public WindowQuestPointer pointer;
    public OrderManager orderManager;
    public GameManager gm;
    public TextMeshProUGUI orderMoneyInfo;
    public NewRandomPlanets np;
    public menu_Items MI;
    public buttonLogic buttonLogic;

    void Start()
    {
       Menu.gameObject.SetActive(false);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PickUpZone")
        {
            Menu.gameObject.SetActive(true);
        }

        if(collision.gameObject.name == MI.PlanetOutcome1.name)
        {
            np.PlanetOutcome1 = null;
            gm.money += np.totalCommision1;
            MI.OnOrder1 = false;
            MI.orderCounter--;
            if (np.PlanetOutcome2 == null)
            {
                np.totalDestinationTime = np.eta - np.totalDestinationTime;
            }

        }

        if (collision.gameObject.name == np.PlanetOutcome2.name)
        {
            MI.RefreshOrders();
            np.PlanetOutcome2 = null;
            gm.money += np.totalCommision2;
            MI.onOrder2 = false;
            MI.orderCounter--;
            if (np.PlanetOutcome1 == null)
            {
                np.totalDestinationTime = np.eta - np.totalDestinationTime;
                gm.money += np.totalDestinationTime;
            }
        }

        if (collision.gameObject.name == np.PlanetOutcome3.name)
        {
            Debug.Log("Its lit 3");
            MI.RefreshOrders();
            np.PlanetOutcome3 = null;
            MI.orderCounter--;
            gm.money += np.totalCommision3;
            MI.onOrder3 = false;
        }





        if (collision.gameObject.tag == "DropOffZone" && orderManager.currentlyHasOrder == true )
        {
            if (collision.gameObject.name == "DropOff")
            {
                gm.money = gm.money + Mathf.Round(orderManager.totalCommision);
                orderManager.currentlyHasOrder = false;
                orderManager.totalCommision = 0;
                pointer.gameObject.SetActive(false);
                orderMoneyInfo.gameObject.SetActive(false);
                StartCoroutine(droppedOff());
                if (orderManager.countDown < orderManager.ETA)
                {
                    gm.money = gm.money + 15f;
                }
            } else if(collision.gameObject.name == "Earth")
            {
                gm.money = gm.money + Mathf.Round(orderManager.totalCommision);
                orderManager.currentlyHasOrder = false;
                orderManager.totalCommision = 0;
                //pointer.gameObject.SetActive(false);
                orderMoneyInfo.gameObject.SetActive(false);
                StartCoroutine(droppedOff());
                if (orderManager.countDown < orderManager.ETA)
                {
                    gm.money = gm.money + 15f;
                }

                Debug.Log("Dropped off at Earth");
            }
            else if (collision.gameObject.name == "Forest")
            {
                gm.money = gm.money + Mathf.Round(orderManager.totalCommision);
                orderManager.currentlyHasOrder = false;
                orderManager.totalCommision = 0;
                //pointer.gameObject.SetActive(false);
                orderMoneyInfo.gameObject.SetActive(false);
                StartCoroutine(droppedOff());
                if (orderManager.countDown < orderManager.ETA)
                {
                    gm.money = gm.money + 15f;
                }

                Debug.Log("Dropped off at Forest Planet");
            }
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PickUpZone")
        {
            Menu.gameObject.SetActive(false);
        }
    }

    public IEnumerator droppedOff()
    {
        orderManager.orderStatus.text = "Order has been dropped off";
        yield return new WaitForSeconds(3f);
        orderManager.orderStatus.text = "";
    }

}
