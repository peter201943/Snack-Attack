

//DECLARATIONS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//PLAYERINVENTORY
public class PlayerInventory : MonoBehaviour
{

    //VARIABLES
    //Weapon Items
        private float marshmellows = 5f;            //Controls whether gun can fire antichocs and anticracks
        private float chocolates = 5f;              //Controls whether gun can fire antimarshs and anticracks
        private float crackers = 5f;                //Controls whether gun can fire antichocs and antimarshs
    //Pickup
        float PickupRange = 5f;                     //How far away a player can be from an item to pick it up


    //AWAKE
    // Start is called before the first frame update
    void Start()
    {
        
    }


    //UPDATE
    //Checks if any valid items in range
    void Update()
    {
        
    }


    //PICKUPCHOCOLATE
    //Adds one Chocolate to inventory
    void PickupChocolate()
    {

    }


    //PICKUPMARSHMELLOW
    //Adds one marshmellow to inventory
    void PickupMarshmellow()
    {

    }


    //PICKUPCRACKER
    //Adds one cracker to inventory
    void PickupCracker()
    {

    }


    //PICKUPHEALTH
    //Adds health to Character
    void PickupHealth()
    {

    }
}

