using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class fuel_and_Mechanic : MonoBehaviour
{
  

    public GameObject fuelStation_UI;
    public GameObject mechanicStation_UI;
   
   
    void Start()
    {
        fuelStation_UI.SetActive(false);
        mechanicStation_UI.SetActive(false);
    }

    
    void Update()
    {
        
    }

 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject.tag == "FuelStation")
        {
            if (collision.gameObject.name == "Player")
            {
             
                fuelStation_UI.SetActive(true);
            }
        }


        if (this.gameObject.tag == "MechanicStation")
        {
            if (collision.gameObject.name == "Player")
            {

               mechanicStation_UI.SetActive(true);
            }
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (this.gameObject.tag == "FuelStation")
        {
            if (collision.gameObject.name == "Player")
            {
            
                fuelStation_UI.SetActive(false);
            }
        }

        if (this.gameObject.tag == "MechanicStation")
        {
            if (collision.gameObject.name == "Player")
            {

                mechanicStation_UI.SetActive(false);
            }
        }
    }


}
