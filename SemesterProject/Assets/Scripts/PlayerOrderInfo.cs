using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerOrderInfo : MonoBehaviour
{
    
    public WindowQuestPointer pointer;
    public OrderManager orderManager;
    public GameManager gm;
    public TextMeshProUGUI orderMoneyInfo;
    public NewRandomPlanets np;
    public menu_Items MI;
    public buttonLogic buttonLogic;

    public GameObject Menu;

    public string destination1, destination2;
    public Transform pickup;
    

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
            buttonLogic.Planet1.GetComponent<TextMeshProUGUI>().text = "";
            buttonLogic.Distance1TXT.gameObject.SetActive(false);
            gm.money = Mathf.RoundToInt(Vector2.Distance(pickup.position, MI.PlanetOutcome1.GetComponent<Transform>().position) * 1.5f);
            MI.OnOrder1 = false;
            MI.orderCounter--;
            if (np.PlanetOutcome2 == null)
            {
                np.totalDestinationTime = np.eta - np.totalDestinationTime;
            }

        }

        if (collision.gameObject.name == MI.PlanetOutcome2.name)
        {
            np.PlanetOutcome2 = null;
            buttonLogic.Planet2.GetComponent<TextMeshProUGUI>().text = "";
            buttonLogic.Distance2TXT.gameObject.SetActive(false);
            gm.money = Mathf.RoundToInt(Vector2.Distance(pickup.position, MI.PlanetOutcome2.GetComponent<Transform>().position) * 1.5f);
            MI.onOrder2 = false;
            MI.orderCounter--;
            if (np.PlanetOutcome1 == null)
            {
                np.totalDestinationTime = np.eta - np.totalDestinationTime;
                gm.money += np.totalDestinationTime;
            }
        }

        if (collision.gameObject.name == MI.PlanetOutcome3.name)
        {
            Debug.Log("Its lit 3");
            MI.RefreshOrders();
            np.PlanetOutcome3 = null;
            MI.orderCounter--;
            gm.money += np.totalCommision3;
            MI.onOrder3 = false;
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
