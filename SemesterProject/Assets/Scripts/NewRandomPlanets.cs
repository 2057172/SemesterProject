using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewRandomPlanets : MonoBehaviour
{

    public GameObject[] Planets = new GameObject[14];
    public GameObject PlanetOutcome1, PlanetOutcome2, PlanetOutcome3;
    public float Distance1, Distance2, Distance3;
    public Vector3 Destination1, Destination2, Destination3;

    public Text Distance1TXT, Distance2TXT, Distance3TXT, Planet1, Planet2, Planet3;

    public Transform Player, pickUpZone;

    public PlayerOrderInfo PI;
    public menu_Items MI;

    public float totalCommision1, totalCommision2, totalCommision3;

    public float destinationTime1, destinationTime2, destinationTime3, totalDestinationTime;
    public bool onOrder;
    public float timeOfDelivery;
    public float eta;

    public void Start()
    {

        onOrder = false;
        Distance1TXT.gameObject.SetActive(false);
        Distance2TXT.gameObject.SetActive(false);
        Distance3TXT.gameObject.SetActive(false);

        Planet1.gameObject.SetActive(false);
        Planet2.gameObject.SetActive(false);
        Planet3.gameObject.SetActive(false);
    }

    public void Update()
    {
        if(PlanetOutcome1 == null && PlanetOutcome2 == null)
        {
            onOrder = false;
            timeOfDelivery = totalDestinationTime - timeOfDelivery;
            Debug.Log(timeOfDelivery);           
        } else {
            onOrder = true;
            totalDestinationTime -= 1 * Time.deltaTime;
        }

        if(MI.OnOrder1 == true)
        {
            Distance1 = Vector3.Distance(Player.position, Destination1);
            Distance1TXT.text = Mathf.RoundToInt(Distance1).ToString() + "m";
        }
        if(MI.onOrder2 == true)
        {
            Distance2 = Vector3.Distance(Player.position, Destination2);
            Distance2TXT.text = Mathf.RoundToInt(Distance2).ToString() + "m";
        }
        if (MI.onOrder3 == true)
        {
            Distance3 = Vector3.Distance(Player.position, Destination3);
            Distance3TXT.text = Mathf.RoundToInt(Distance3).ToString() + "m";
        } if (MI.OnOrder1 == false)
        {
            Distance1TXT.gameObject.SetActive(false);
            Planet1.gameObject.SetActive(false);
        }
        if (MI.onOrder2 == false)
        {
            Distance2TXT.gameObject.SetActive(false);
            Planet2.gameObject.SetActive(false);
        }
        if (MI.onOrder3 == false)
        {
            Distance3TXT.gameObject.SetActive(false);
            Planet3.gameObject.SetActive(false);
        }
    }
    public void Refresh()
    {
        for(int count = 0; count < 3; count++)
        {
            if(count == 0)
            {

                PlanetOutcome1 = Planets[Random.Range(0, Planets.Length)];

            } else if(count == 1)
            {
                PlanetOutcome2 = Planets[Random.Range(0, Planets.Length)];
            }
            else if (count == 2)
            {
                PlanetOutcome3 = Planets[Random.Range(0, Planets.Length)];
            }
        }

    }

    public void fillOrders()
    {
        onOrder = true;
        PI.Menu.gameObject.SetActive(false);

        for (int count = 0; count < 3; count++)
        {
            if (count == 0)
            {
               
                if (MI.OnOrder1 == true)
                {
                    Distance1TXT.gameObject.SetActive(true);
                    Planet1.gameObject.SetActive(true);

                    PlanetOutcome1 = Planets[Random.Range(0, Planets.Length)];
                    Destination1 = PlanetOutcome1.transform.position;

                    Distance1 = Vector3.Distance(Player.position, Destination1);
                    Distance1TXT.text = Mathf.RoundToInt(Distance1).ToString() + "m";
                    Planet1.text = PlanetOutcome1.name;

                    totalCommision1 = 20 + (Vector3.Distance(pickUpZone.position, PlanetOutcome1.gameObject.GetComponent<Transform>().position) * 0.8f);
                }

                destinationTime1 = Vector3.Distance(pickUpZone.position, PlanetOutcome1.gameObject.GetComponent<Transform>().position) * 1.2f;
                //+
                // Vector3.Distance(pickUpZone.position, PlanetOutcome3.gameObject.GetComponent<Transform>().position); */

                Debug.Log("Destination 1: " + destinationTime1);
            }
            else if (count == 1)
            {
                if(MI.onOrder2 == true) {

                    Distance2TXT.gameObject.SetActive(true);
                    Planet2.gameObject.SetActive(true);

                    PlanetOutcome2 = Planets[Random.Range(0, Planets.Length)];
                    Destination2 = PlanetOutcome2.transform.position;

                    Distance2 = Vector3.Distance(Player.position, Destination2);
                    Distance2TXT.text = Mathf.RoundToInt(Distance2).ToString() + "m";
                    Planet2.text = PlanetOutcome2.name;

                    totalCommision2 = 20 + (Vector3.Distance(pickUpZone.position, PlanetOutcome2.gameObject.GetComponent<Transform>().position) * 0.8f);

                    destinationTime2 = Vector3.Distance(pickUpZone.position, PlanetOutcome2.gameObject.GetComponent<Transform>().position) * 1.2f;
                    totalDestinationTime = destinationTime1 + destinationTime2 + destinationTime3;

                    Debug.Log("Destination 2: " + destinationTime2);
                    Debug.Log("Total: " + totalDestinationTime);
                }               

            }
            else if (count == 2)
            {
                if(MI.onOrder3 == true)
                {
                    Distance3TXT.gameObject.SetActive(true);
                    Planet3.gameObject.SetActive(true);

                    PlanetOutcome3 = Planets[Random.Range(0, Planets.Length)];
                    Destination3 = PlanetOutcome3.transform.position;

                    Distance3 = Vector3.Distance(Player.position, Destination3);
                    Distance3TXT.text = Mathf.RoundToInt(Distance3).ToString() + "m";
                    Planet3.text = PlanetOutcome3.name;

                    totalCommision3 = 20 + (Vector3.Distance(pickUpZone.position, PlanetOutcome3.gameObject.GetComponent<Transform>().position) * 0.8f);

                    destinationTime3 = Vector3.Distance(pickUpZone.position, PlanetOutcome3.gameObject.GetComponent<Transform>().position) * 1.2f;
                    totalDestinationTime = destinationTime1 + destinationTime2 + destinationTime3;

                    Debug.Log("Destination 3: " + destinationTime3);
                    Debug.Log("Total: " + totalDestinationTime);
                }
            } eta = totalDestinationTime;
        }

    }


}
