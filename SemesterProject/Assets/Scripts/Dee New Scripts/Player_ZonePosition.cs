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

    public bool canTakeHeatDamage=true;
    public int heatSeconds = 5;
    public int heatDamage = 2;


    void Start()
    {
       

    }

    private void Awake()
    {
        
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


        //INSIDE HEAT ZONE
        if (spaceship_distance > normalZoneEdge.transform.position.y && spaceship_distance < heatZoneEdge.transform.position.y)
        {
            isInHeatZone = true;

            //IF PLAYER DOES NOT HAVE HEAT PROTECTION 
            if (isInHeatZone == true && upgradeShop.firePurchased == false && canTakeHeatDamage ==true )
            {
                checkHeatDamage();

            }
            //IF PLAYER DOES HAVE HEAT PROTECTION
            if ( upgradeShop.firePurchased == true )
            {
                canTakeHeatDamage = false;

            }
        }
        else
        {
            isInHeatZone = false;
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


   
    public void checkHeatDamage()
    {

        StartCoroutine(TakeHeatDamage());

        
    }

    public IEnumerator TakeHeatDamage()
    {
        canTakeHeatDamage = false;
        yield return new WaitForSeconds(heatSeconds);
        playerMovement.currentHealth -= heatDamage;
        Health_And_Fuel.setCurrentHealth(playerMovement.currentHealth);
        canTakeHeatDamage = true;
    }





}
