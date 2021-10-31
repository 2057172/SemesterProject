using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ZonePosition : MonoBehaviour
{

    public playerMovement playerMovement;
    public health_and_fuel Health_And_Fuel;
    public UpgradeShop upgradeShop;

    public float spaceship_distance;
    public Transform spaceship;

    public Transform normalZoneEdge;
    public Transform heatZoneEdge;
    public Transform iceZoneEdge;
    public Transform radiationZoneEdge;
    public Transform hardcoreZoneEdge;


    public bool isInNormalZone;
    public bool isInHeatZone;
    public bool isInIceZone;
    public bool isInRadiationZone;
    public bool isInHardcoreZone;

    void Start()
    {
        //INSIDE HEAT ZONE
        if (spaceship_distance > normalZoneEdge.transform.position.y && spaceship_distance < heatZoneEdge.transform.position.y)
        {
            isInHeatZone = true;

            if (isInHeatZone == true && upgradeShop.firePurchased == false)
            {
                InvokeRepeating("TakeHeatDamage", 5.0f, 5f);
            }
        }
        else
        {
            isInHeatZone = false;
        }

    }


    void Update()
    {
        spaceship_distance = Vector3.Distance(Vector3.zero, spaceship.position);

        //INSIDE NORMAL ZONE
        if (spaceship_distance <= normalZoneEdge.transform.position.y)
        {
            isInNormalZone = true;

            
        }
        else
        {
            isInNormalZone = false;

        }


       

        //INSIDE ICE ZONE
        if (spaceship_distance > heatZoneEdge.transform.position.y && spaceship_distance < iceZoneEdge.transform.position.y)
        {
            isInIceZone = true;
        }
        else
        {
            isInIceZone = false;
        }

        //INSIDE RADIATION ZONE
        if (spaceship_distance > iceZoneEdge.transform.position.y && spaceship_distance < radiationZoneEdge.transform.position.y)
        {
            isInRadiationZone = true;
        }
        else
        {
            isInRadiationZone = false;
        }

        //INSIDE HARDCORE ZONE
        if (spaceship_distance > radiationZoneEdge.transform.position.y && spaceship_distance < hardcoreZoneEdge.transform.position.y)
        {
            isInHardcoreZone = true;
        }
        else
        {
            isInHardcoreZone = false;
        }
    }








    public void TakeHeatDamage()
    {
        playerMovement.currentHealth -= 2;
        Health_And_Fuel.setCurrentHealth(playerMovement.currentHealth);
    }



}
