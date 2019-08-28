

//NOTES
/*
 * Ammo Logic is done in the PlayerAttack script
 * This script ONLY tracks numbers, it does not make decisions
 */

//DECLARATIONS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;               //Added for UI Components


//PLAYERINVENTORY
//Allows player to run out of things
public class PlayerInventory : MonoBehaviour
{

    //VARIABLES

        //Player
        private GameObject Player;

        //Weapon Items
        private int Marshmellows;                   //Controls whether gun can fire antichocs and anticracks
        private int Chocolates;                     //Controls whether gun can fire antimarshs and anticracks
        private int Crackers;                       //Controls whether gun can fire antichocs and antimarshs

        //Default Values
        public int StartingMarshmellows = 50;       //How many Marshmellows the player starts with
        public int StartingChocolates = 50;         //How many Chocolates the player starts with
        public int StartingCrackers = 50;           //How many Crackers the player starts with

        //Logic
        float PickupRange = 5f;                     //How far away a player can be from an item to pick it up

        //Effects
        public Slider MarshmellowBar;               //Shows Marshmellows to player
        public Slider CrackerBar;                   //Shows Crackers to player
        public Slider ChocolateBar;                 //Shows Chocolates to player


    //AWAKE
    //Assign player and base values
    void Awake()
    {
        Marshmellows = StartingMarshmellows;
    }


    //UPDATE
    //Checks if any valid items in range
    void Update()
    {
        
    }


    //==============================================================================
    //PICKUPS
    //Add items to inventory
    //==============================================================================


    //PICKUPCHOCOLATE
    //Adds some Chocolates to inventory
    public void PickupChocolate(int Amount)
    {

    }


    //PICKUPMARSHMELLOW
    //Adds some marshmellows to inventory
    public void PickupMarshmellow(int Amount)
    {

    }


    //PICKUPCRACKER
    //Adds some crackers to inventory
    public void PickupCracker(int Amount)
    {

    }


    //PICKUPHEALTH
    //Adds some health to Character
    public void PickupHealth(int Amount)
    {

    }


    //==============================================================================
    //DROPPERS
    //Remove items from inventory
    //==============================================================================

    //DROPCHOCOLATE
    //Removes some Chocolates from inventory
    public void DropChocolate(int Amount)
    {

    }


    //DROPMARSHMELLOW
    //Removes some marshmellows from inventory
    public void DropMarshmellow(int Amount)
    {

    }


    //DROPCRACKER
    //Removes some crackers from inventory
    public void DropCracker(int Amount)
    {

    }
}

