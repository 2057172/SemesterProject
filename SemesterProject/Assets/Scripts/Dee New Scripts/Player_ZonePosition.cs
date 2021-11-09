using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player_ZonePosition : MonoBehaviour
{

    public playerMovement playerMovement;
    public health_and_fuel Health_And_Fuel;
    public UpgradeShop upgradeShop;

    public float spaceship_distance;
    public Transform spaceship;

    public Transform normalZoneEdge;
    public Transform iceZoneEdge;
    public Transform heatZoneEdge;
    public Transform radiationZoneEdge;
    public Transform hardcoreZoneEdge;


    public bool isInNormalZone;
    public bool isInHeatZone;
    public bool isInIceZone;
    public bool isInRadiationZone;
    public bool isInHardcoreZone;

    //HEAT ZONE HEALTH DAMAGE DAMAGE
    public bool canTakeHeatDamage=true;
    public int heatSeconds = 5;
    public int heatDamage = 2;

    //HARDCORE ZONE DAMAGE
    public bool canTakeHardcoreHeatDamage = true;
    public int hardcoreHeatSeconds = 5;
    public int hardcoreHeatDamage = 15;

    public TextMeshProUGUI dangerAlert;


    //MAP STUFF FOR RADIATION ZONE
    public GameObject miniMap;

    

    void Start()
    {

        dangerAlert.text = "";
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




        //INSIDE ICE ZONE
        if (spaceship_distance > normalZoneEdge.transform.position.y && spaceship_distance < iceZoneEdge.transform.position.y)
        {
            isInIceZone = true;


            //IF PLAYER DOES NOT HAVE ICE PROTECTION 
            if (isInIceZone == true && upgradeShop.icePurchased == false)
            {
                dangerAlert.text = "ICE DAMAGE DAMAGE!";

                //CAM PLS PUT CODE TO SLOW DOWN SHIP WHEN IN THIS ZONE HERE
                playerMovement.maxSpeed = 3;
            }
            //IF PLAYER DOES HAVE ICE PROTECTION
            if (upgradeShop.icePurchased == true)
            {
                playerMovement.maxSpeed = 6;
                dangerAlert.text = "";
                //CODE TO MAKE SHIP GO FAST AGAIN
            }


        }


        else
        {
            isInIceZone = false;

            if (isInIceZone == false && isInNormalZone==true ||isInHeatZone==true || isInRadiationZone==true)
            {
                playerMovement.maxSpeed = 6;
            }

           
        }


        //INSIDE HEAT ZONE
        if (spaceship_distance > iceZoneEdge.transform.position.y && spaceship_distance < heatZoneEdge.transform.position.y)
        {
            isInHeatZone = true;

            //IF PLAYER DOES NOT HAVE HEAT PROTECTION 
            if (isInHeatZone == true && upgradeShop.firePurchased == false && canTakeHeatDamage == true)
            {
                dangerAlert.text = "HEAT DAMAGE!";
                checkHeatDamage();

                StopCoroutine(TakeHeatDamage());
            }
            //IF PLAYER DOES HAVE HEAT PROTECTION
            if (upgradeShop.firePurchased == true)
            {
                canTakeHeatDamage = false;
                dangerAlert.text = "";
                StopCoroutine(TakeHeatDamage());
            }
        }
        else
        {
            isInHeatZone = false;
        }

        //INSIDE RADIATION ZONE
        if (spaceship_distance > heatZoneEdge.transform.position.y && spaceship_distance < radiationZoneEdge.transform.position.y)
        {
            isInRadiationZone = true;
            //IF PLAYER DOES NOT HAVE RADIATION PROTECTION 
            if (isInRadiationZone == true && upgradeShop.radPurchased == false)
            {
                
                dangerAlert.text = "RADIATION DAMAGE!";
                miniMap.SetActive(false);
                
            }
            //IF PLAYER DOES HAVE RADIATION PROTECTION
            if (upgradeShop.radPurchased == true)
            {
                dangerAlert.text = "";
                miniMap.SetActive(true);

                //CODE TO MAKE SHIP GO FAST AGAIN
            }
        }
        else
        {
            isInRadiationZone = false;
            
        }

        //INSIDE HARDCORE ZONE
        if (spaceship_distance > radiationZoneEdge.transform.position.y && spaceship_distance < hardcoreZoneEdge.transform.position.y)
        {
            isInHardcoreZone = true;
            //IF PLAYER DOES NOT HAVE HARDCORE PROTECTION 
            if (isInHardcoreZone == true && upgradeShop.hardcorePurchased == false && canTakeHardcoreHeatDamage==true && isInIceZone==false)
            {

                dangerAlert.text = "HARDCORE DAMAGE!";

                //MORE DAMAGE TAKEN
                checkHardcoreHeatDamage();
                //SHIP SLOWED DOWN EVEN MORE
                //CAM PLS PUT CODE TO SLOW DOWN SHIP EVEN MORE HERE 
                playerMovement.maxSpeed = 1.5f;

                //MINI MAP DISABLED 
                miniMap.SetActive(false);

            }
            //IF PLAYER DOES HAVE RADIATION PROTECTION
            if (upgradeShop.hardcorePurchased == true)
            {
                dangerAlert.text = "";
                playerMovement.maxSpeed = 6;
            }

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

    public void checkHardcoreHeatDamage()
    {

        StartCoroutine(TakeHardcoreHeatDamage());
        //StartCoroutine(TakeHeatDamage());


    }

    public IEnumerator TakeHeatDamage()
    {
        canTakeHeatDamage = false;
        yield return new WaitForSeconds(heatSeconds);
        playerMovement.currentHealth -= heatDamage;
        Health_And_Fuel.setCurrentHealth(playerMovement.currentHealth);
        canTakeHeatDamage = true;
    }


    public IEnumerator TakeHardcoreHeatDamage()
    {
        canTakeHardcoreHeatDamage = false;
        yield return new WaitForSeconds(hardcoreHeatSeconds);
        playerMovement.currentHealth -= hardcoreHeatDamage;
        Health_And_Fuel.setCurrentHealth(playerMovement.currentHealth);
        canTakeHardcoreHeatDamage = true;
    }





}
