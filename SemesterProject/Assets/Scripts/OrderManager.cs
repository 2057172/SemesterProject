using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderManager : MonoBehaviour
{
    public WindowQuestPointer pointer;

    public bool currentlyHasOrder;
    public bool BurgerAndFriesB, IceCreamB, SandwichB;

    public Transform BurgerAndFriedDropoff;
    void Start()
    {
        currentlyHasOrder = false;

        BurgerAndFriesB = false;
        IceCreamB = false;
        SandwichB = false;
    }


    public void BurgerAndFries()
    {
        currentlyHasOrder = true;
        BurgerAndFriesB = true;
        pointer.targetPosition = BurgerAndFriedDropoff.position;
    }
}
