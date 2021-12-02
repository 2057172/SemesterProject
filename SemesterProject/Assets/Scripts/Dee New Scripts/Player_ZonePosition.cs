using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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

    


    //MAP STUFF FOR RADIATION ZONE
    public GameObject miniMap;




    //STUFF FOR BUTTONS
    //UPGRADE BUTTONS
 

    public TextMeshProUGUI status;
    public GameObject statusBar;

  

    public GameObject danger_Icon_disabled;
    public GameObject danger_Icon_enabled;

    public GameObject ice_Icon_disabled;
    public GameObject ice_Icon_enabled;

    public GameObject fire_Icon_disabled;
    public GameObject fire_Icon_enabled;

    public GameObject radiation_Icon_disabled;
    public GameObject radiation_Icon_enabled;

    public GameObject hardcore_Icon_disabled;
    public GameObject hardcore_Icon_enabled;


    void Start()
    {

        
        danger_Icon_disabled.SetActive(true);
        ice_Icon_disabled.SetActive(true);
        fire_Icon_disabled.SetActive(true);
        radiation_Icon_disabled.SetActive(true);
        hardcore_Icon_disabled.SetActive(true);


        danger_Icon_enabled.SetActive(false);
        ice_Icon_enabled.SetActive(false);
        fire_Icon_enabled.SetActive(false);
        radiation_Icon_enabled.SetActive(false);
        hardcore_Icon_enabled.SetActive(false); 

        statusBar.SetActive(false);
        status.text = ""; 
     
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
 
            danger_Icon_disabled.SetActive(true);
            ice_Icon_disabled.SetActive(true);
            fire_Icon_disabled.SetActive(true);
            radiation_Icon_disabled.SetActive(true);
            hardcore_Icon_disabled.SetActive(true);


            danger_Icon_enabled.SetActive(false);
            ice_Icon_enabled.SetActive(false);
            fire_Icon_enabled.SetActive(false);
            radiation_Icon_enabled.SetActive(false);
            hardcore_Icon_enabled.SetActive(false);

            statusBar.SetActive(false);
            status.text = ""; 

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
            if (isInIceZone == true)
            { if(upgradeShop.icePurchased == false)
                {
                  

                    //PUT CODE TO SLOW DOWN SHIP WHEN IN THIS ZONE HERE
                    playerMovement.maxSpeed = 3;

                    //ICON
                   ice_Icon_disabled.SetActive(false);
                    ice_Icon_enabled.SetActive(true);

                    fire_Icon_disabled.SetActive(true);
                    fire_Icon_enabled.SetActive(false);

                    danger_Icon_disabled.SetActive(false);
                    danger_Icon_enabled.SetActive(true);

                    

                    statusBar.SetActive(true);
                    status.text = "ENGINE SYSTEM: <color=#f02005>CRITICAL</color>";
                }
              



            }
            //IF PLAYER DOES HAVE ICE PROTECTION
            if (upgradeShop.icePurchased == true)
            {
                playerMovement.maxSpeed = 6;
               
                //CODE TO MAKE SHIP GO FAST AGAIN
        


                //ICON
                danger_Icon_disabled.SetActive(true);
                ice_Icon_disabled.SetActive(true);
                fire_Icon_disabled.SetActive(true);
                radiation_Icon_disabled.SetActive(true);
                hardcore_Icon_disabled.SetActive(true);


                danger_Icon_enabled.SetActive(false);
                ice_Icon_enabled.SetActive(false);
                fire_Icon_enabled.SetActive(false);
                radiation_Icon_enabled.SetActive(false);
                hardcore_Icon_enabled.SetActive(false);
                
                statusBar.SetActive(false);
                status.text = "";
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
                
                checkHeatDamage();

                StopCoroutine(TakeHeatDamage());


                //ICONS
                fire_Icon_disabled.SetActive(false);
                fire_Icon_enabled.SetActive(true);

                danger_Icon_enabled.SetActive(true);
                danger_Icon_disabled.SetActive(false);

                ice_Icon_enabled.SetActive(false);
                ice_Icon_disabled.SetActive(true);

                radiation_Icon_disabled.SetActive(true);
                radiation_Icon_enabled.SetActive(false);

                statusBar.SetActive(true);
                status.text = "HEALTH SYSTEM: <color=#f02005>CRITICAL</color>";
            }
            //IF PLAYER DOES HAVE HEAT PROTECTION
            if (upgradeShop.firePurchased == true)
            {
                canTakeHeatDamage = false;
               
                StopCoroutine(TakeHeatDamage());


                //ICON
                danger_Icon_disabled.SetActive(true);
                ice_Icon_disabled.SetActive(true);
                fire_Icon_disabled.SetActive(true);
                radiation_Icon_disabled.SetActive(true);
                hardcore_Icon_disabled.SetActive(true);


                danger_Icon_enabled.SetActive(false);
                ice_Icon_enabled.SetActive(false);
                fire_Icon_enabled.SetActive(false);
                radiation_Icon_enabled.SetActive(false);
                hardcore_Icon_enabled.SetActive(false);

                statusBar.SetActive(false);
                status.text = "";

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
            if (isInRadiationZone == true && upgradeShop.radPurchased==false)
            {
                
                
                miniMap.SetActive(false);

                
                radiation_Icon_disabled.SetActive(false);
                radiation_Icon_enabled.SetActive(true);

                danger_Icon_enabled.SetActive(true);
                danger_Icon_disabled.SetActive(false);


               
                ice_Icon_disabled.SetActive(true);
                fire_Icon_disabled.SetActive(true);
                hardcore_Icon_disabled.SetActive(true);


             
                ice_Icon_enabled.SetActive(false);
                fire_Icon_enabled.SetActive(false);
                hardcore_Icon_enabled.SetActive(false);

                statusBar.SetActive(true);
                status.text = "MAP SYSTEM: <color=#f02005>CRITICAL</color>";

            }
            //IF PLAYER DOES HAVE RADIATION PROTECTION
            if (upgradeShop.radPurchased == true)
            {
                
                miniMap.SetActive(true);

                danger_Icon_disabled.SetActive(true);
                danger_Icon_enabled.SetActive(false);


                //ICON
                danger_Icon_disabled.SetActive(true);
                ice_Icon_disabled.SetActive(true);
                fire_Icon_disabled.SetActive(true);
                radiation_Icon_disabled.SetActive(true);
                hardcore_Icon_disabled.SetActive(true);


                danger_Icon_enabled.SetActive(false);
                ice_Icon_enabled.SetActive(false);
                fire_Icon_enabled.SetActive(false);
                radiation_Icon_enabled.SetActive(false);
                hardcore_Icon_enabled.SetActive(false);

                statusBar.SetActive(false);
                status.text = "";
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

               

                //MORE DAMAGE TAKEN
                checkHardcoreHeatDamage();
                //SHIP SLOWED DOWN EVEN MORE
                //CAM PLS PUT CODE TO SLOW DOWN SHIP EVEN MORE HERE 
                playerMovement.maxSpeed = 1.5f;

                //MINI MAP DISABLED 
                miniMap.SetActive(false);


                hardcore_Icon_enabled.SetActive(true);
                hardcore_Icon_disabled.SetActive(false);

                danger_Icon_disabled.SetActive(false);
                danger_Icon_enabled.SetActive(true);

              
                ice_Icon_disabled.SetActive(false);
                ice_Icon_enabled.SetActive(true);

                fire_Icon_disabled.SetActive(false);
                fire_Icon_enabled.SetActive(true);

                radiation_Icon_disabled.SetActive(false);
                radiation_Icon_enabled.SetActive(true);





                statusBar.SetActive(true);
                status.text = "ALL SYSTEMS: <color=#f02005>CRITICAL</color>";



            }
            //IF PLAYER DOES HAVE RADIATION PROTECTION
            if (upgradeShop.hardcorePurchased == true)
            {
                
                playerMovement.maxSpeed = 6;

                //ICON
                danger_Icon_disabled.SetActive(true);
                ice_Icon_disabled.SetActive(true);
                fire_Icon_disabled.SetActive(true);
                radiation_Icon_disabled.SetActive(true);
                hardcore_Icon_disabled.SetActive(true);


                danger_Icon_enabled.SetActive(false);
                ice_Icon_enabled.SetActive(false);
                fire_Icon_enabled.SetActive(false);
                radiation_Icon_enabled.SetActive(false);
                hardcore_Icon_enabled.SetActive(false);

                statusBar.SetActive(false);
                status.text = "";
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
