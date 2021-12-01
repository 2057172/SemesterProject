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
<<<<<<< Updated upstream
=======
    public buttonLogic bl;

    public string destination1, destination2;

    public Transform pickup;

    public GameObject menu2;
>>>>>>> Stashed changes

    void Start()
    {
        menu2.gameObject.SetActive(false);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PickUpZone")
        {
            menu2.gameObject.SetActive(true);
        }

        if (collision.gameObject.name == destination1)
        {
            Debug.Log("Its lit");
            np.PlanetOutcome1 = null;
            bl.Planet1.GetComponent<TextMeshProUGUI>().text = "";
            bl.Distance1TXT.gameObject.SetActive(false);
            gm.money += Mathf.RoundToInt(Vector2.Distance(pickup.position, MI.PlanetOutcome1.GetComponent<RectTransform>().position) * 1.5f);
            MI.OnOrder1 = false;
            if (np.PlanetOutcome2 == null)
            {
                np.totalDestinationTime = np.eta - np.totalDestinationTime;
            }

        }

        if (collision.gameObject.name == destination2)
        {
            Debug.Log("Its lit 2");
            np.PlanetOutcome2 = null;
            bl.Distance2TXT.text = "";
            bl.Planet2.GetComponent<TextMeshProUGUI>().text = "";
            gm.money += np.totalCommision2;
            MI.onOrder2 = false;          
            if(np.PlanetOutcome1 == null)
            {
                np.totalDestinationTime = np.eta - np.totalDestinationTime;
                gm.money += np.totalDestinationTime;
            }
        }

        if (collision.gameObject.name == MI.PlanetOutcome3.name)
        {
<<<<<<< Updated upstream
            Debug.Log("Its lit 3");
=======
           
            MI.RefreshOrders();
>>>>>>> Stashed changes
            np.PlanetOutcome3 = null;
            gm.money += np.totalCommision3;
            MI.onOrder3 = false;
        }

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PickUpZone")
        {
            menu2.gameObject.SetActive(false);
        }
    }

    public IEnumerator droppedOff()
    {
        orderManager.orderStatus.text = "Order has been dropped off";
        yield return new WaitForSeconds(3f);
        orderManager.orderStatus.text = "";
    }

}
