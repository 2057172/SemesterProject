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

    public TextMeshProUGUI dangerAlert;


    //MAP STUFF FOR RADIATION ZONE
    public GameObject miniMap;




    //STUFF FOR BUTTONS
    //UPGRADE BUTTONS
    public Button healthUpgrade1;
    public Button healthUpgrade2;
    public Button healthUpgrade3;

    public Button fuelUpgrade1;
    public Button fuelUpgrade2;
    public Button fuelUpgrade3;

    public Button carryCapacity1;
    public Button carryCapacity2;
    public Button carryCapacity3;
    public Button carryCapacity4;

    public Button iceUpgrade;
    public Button heatUpgrade;
    public Button radiationUpgrade;
    public Button hardcoreUpgrade;

    public Button repairButton;

    //COLOURS 
    public Color green1;
    public Color green2;
    public Color green3;
    public Color green4;


    public Color blue1;
    public Color blue2;
    public Color blue3;
    public Color blue4;

    public Color red1;
    public Color red2;
    public Color red3;
    public Color red4;

    public Color purple1;
    public Color purple2;
    public Color purple3;
    public Color purple4;


    public Color black1;
    public Color black2;
    public Color black3;
    public Color black4;
    
    
    void Start()
    {


        //Changes the button's Normal color to the new color.
     
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

            //UPGRADE UI COLOUR IN ICE ZONE
            ColorBlock hu1 = healthUpgrade1.colors;
            hu1.normalColor = blue1;
            healthUpgrade1.colors = hu1;

            ColorBlock fu1 = fuelUpgrade1.colors;
            fu1.normalColor = blue1;
            fuelUpgrade1.colors = fu1;

            ColorBlock cu1 = carryCapacity1.colors;
            cu1.normalColor = blue1;
            carryCapacity1.colors =cu1;

            ColorBlock ice = iceUpgrade.colors;
            ice.normalColor = blue1;
            iceUpgrade.colors = ice;


            ColorBlock hu2 = healthUpgrade2.colors;
            hu2.normalColor = blue2;
            healthUpgrade2.colors = hu2;

            ColorBlock fu2 = fuelUpgrade2.colors;
            fu2.normalColor = blue2;
            fuelUpgrade2.colors = fu2;

            ColorBlock cu2 = carryCapacity2.colors;
            cu2.normalColor = blue2;
            carryCapacity2.colors = cu2;

            ColorBlock heat = heatUpgrade.colors;
            heat.normalColor = blue2;
            heatUpgrade.colors = heat;


            ColorBlock hu3 = healthUpgrade3.colors;
            hu3.normalColor = blue3;
            healthUpgrade3.colors = hu3;

            ColorBlock fu3 = fuelUpgrade3.colors;
            fu3.normalColor = blue3;
            fuelUpgrade3.colors = fu3;

            ColorBlock cu3 = carryCapacity3.colors;
            cu3.normalColor = blue3;
            carryCapacity3.colors = cu3;

            ColorBlock rad = radiationUpgrade.colors;
            rad.normalColor = blue3;
            radiationUpgrade.colors = rad;


            ColorBlock hard = hardcoreUpgrade.colors;
            hard.normalColor = blue4;
            hardcoreUpgrade.colors = hard;

            ColorBlock repair = repairButton.colors;
            repair.normalColor = blue4;
            repairButton.colors = repair;

            //IF PLAYER DOES NOT HAVE ICE PROTECTION 
            if (isInIceZone == true && upgradeShop.icePurchased == false)
            {
                dangerAlert.text = "ICE DAMAGE DAMAGE!";

                //PUT CODE TO SLOW DOWN SHIP WHEN IN THIS ZONE HERE
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

            //UPGRADE UI COLOUR IN RADIATION ZONE
            ColorBlock hu1 = healthUpgrade1.colors;
            hu1.normalColor = purple1;
            healthUpgrade1.colors = hu1;

            ColorBlock fu1 = fuelUpgrade1.colors;
            fu1.normalColor = purple1;
            fuelUpgrade1.colors = fu1;

            ColorBlock cu1 = carryCapacity1.colors;
            cu1.normalColor = purple1;
            carryCapacity1.colors = cu1;

            ColorBlock ice = iceUpgrade.colors;
            ice.normalColor = purple1;
            iceUpgrade.colors = ice;


            ColorBlock hu2 = healthUpgrade2.colors;
            hu2.normalColor = purple1;
            healthUpgrade2.colors = hu2;

            ColorBlock fu2 = fuelUpgrade2.colors;
            fu2.normalColor = purple2;
            fuelUpgrade2.colors = fu2;

            ColorBlock cu2 = carryCapacity2.colors;
            cu2.normalColor = purple2;
            carryCapacity2.colors = cu2;

            ColorBlock heat = heatUpgrade.colors;
            heat.normalColor = purple2;
            heatUpgrade.colors = heat;


            ColorBlock hu3 = healthUpgrade3.colors;
            hu3.normalColor = purple3;
            healthUpgrade3.colors = hu3;

            ColorBlock fu3 = fuelUpgrade3.colors;
            fu3.normalColor = purple3;
            fuelUpgrade3.colors = fu3;

            ColorBlock cu3 = carryCapacity3.colors;
            cu3.normalColor = purple3;
            carryCapacity3.colors = cu3;

            ColorBlock rad = radiationUpgrade.colors;
            rad.normalColor = purple3;
            radiationUpgrade.colors = rad;


            ColorBlock hard = hardcoreUpgrade.colors;
            hard.normalColor = purple4;
            hardcoreUpgrade.colors = hard;

            ColorBlock repair = repairButton.colors;
            repair.normalColor = purple4;
            repairButton.colors = repair;

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



            //UPGRADE UI COLOUR IN HARDCORE ZONE
            healthUpgrade1.GetComponent<Image>().color = black1;
            fuelUpgrade1.GetComponent<Image>().color = black1;
            carryCapacity1.GetComponent<Image>().color = black1;
            iceUpgrade.GetComponent<Image>().color = black1;

            healthUpgrade2.GetComponent<Image>().color = black2;
            fuelUpgrade2.GetComponent<Image>().color = black2;
            carryCapacity2.GetComponent<Image>().color = black2;
            heatUpgrade.GetComponent<Image>().color = black2;

            healthUpgrade3.GetComponent<Image>().color = black3;
            fuelUpgrade3.GetComponent<Image>().color = black3;
            carryCapacity3.GetComponent<Image>().color = black3;
            radiationUpgrade.GetComponent<Image>().color = black3;

            repairButton.GetComponent<Image>().color = black4;
            hardcoreUpgrade.GetComponent<Image>().color = black4;

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
