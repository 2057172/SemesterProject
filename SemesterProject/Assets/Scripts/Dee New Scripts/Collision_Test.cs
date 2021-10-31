using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Test : MonoBehaviour
{

    public Collider2D normalZoneColliderEdge;

    public Collider2D heatZoneCollider;
    public Collider2D heatZoneColliderEdge;

    public Collider2D iceZoneCollider;
    public Collider2D iceZoneColliderEdge;

    public Collider2D radiationZoneCollider;
    public Collider2D radiationZoneColliderEdge;

    public Collider2D hardcoreZoneCollider;

    void Start()
    {
       
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //IN THE NORMAL ZONE ALL OTHER ZONES ARE DISABLED
        if (collision.gameObject.name == "Normal Zone Collider")
        {
            Debug.Log("Yee");

            heatZoneCollider.enabled = false;
            iceZoneCollider.enabled = false;
            radiationZoneCollider.enabled = false;
            hardcoreZoneCollider.enabled = false;
            
        }

        //END OF NORMAL ZONE START OF HEAT ZONE
        if (collision.gameObject.name == "Normal Zone Collider Edge")
        {
            Debug.Log("Yee2");

            heatZoneCollider.enabled = true;

        }

        //END OF ICE ZONE START OF RADIATION ZONE
        if (collision.gameObject.name == "Heat Zone Collider Edge ")
        {
            Debug.Log("Yee3");

            iceZoneCollider.enabled = true;

        }

        //END OF ICE ZONE START OF RADIATION ZONE
        if (collision.gameObject.name == "Ice Zone Collider Edge")
        {
            Debug.Log("Yee4");
            radiationZoneCollider.enabled = true;

        }


        //END OF RADIATION ZONE START OF HARDCORE ZONE
        if (collision.gameObject.name == "Radiation Zone Collider Edge")
        {
            Debug.Log("Yee5");
            hardcoreZoneCollider.enabled = true;

        }
    }


}
