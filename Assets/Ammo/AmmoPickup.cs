

//NOTES
/*
 * Ammo Type Codes are as follows:
 * 1 - Cracker
 * 2 - Chocolate
 * 3 - Marshmellow
 * 4 - Health
 */


//DECLARATIONS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//AMMOPICKUP
//Adds ammo or health to picker-upper
public class AmmoPickup : MonoBehaviour
{

    //VARIABLES

        //Ammo
        public int AmmoAmount = 10;         //Default Ammo Size
        public int AmmoType = 1;            //Default Ammo Type is cracker

        //Logic
        bool ChocolateType = false;         //Controls what ammo to award
        bool CrackerType = false;           //Controls what ammo to award
        bool MarshmellowType = false;       //Controls what ammo to award
        bool HealthType = false;            //Controls what ammo to award

        //Target
        GameObject Player;                  //Allows Ammo to see the player
        PlayerInventory PlayerAmmo;         //What this script affects
        PlayerHealth PlayerLife;            //What this script affects


    //AWAKE
    //Finds the player and their stuff
    void Awake()
    {
        //Set Target Inventory
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerAmmo = Player.GetComponent<PlayerInventory>();
        PlayerLife = Player.GetComponent<PlayerHealth>();
        //Set ammo type
        //Marshmellow Ammo
        if (AmmoType == 1)
        {
            MarshmellowType = true;
        }
        //Chocolate Ammo
        else if (AmmoType == 2)
        {
            ChocolateType = true;
        }
        //Cracker Ammo
        else if (AmmoType == 3)
        {
            CrackerType = true;
        }
        //Health "Ammo"
        else if (AmmoType == 4)
        {
            HealthType = true;
        }
    }


    //ONTRIGGERENTER
    //Checks if something in range is the player and adds ammo if so
    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject == Player)
        {
            //Pick which ammo to award
            //Chocolate Ammo
            if (ChocolateType)
            {
                PlayerAmmo.PickupChocolate(AmmoAmount);
            }
            //Cracker Ammo
            else if (CrackerType)
            {
                PlayerAmmo.PickupCracker(AmmoAmount);
            }
            //Marshmellow Ammo
            else if (MarshmellowType)
            {
                PlayerAmmo.PickupMarshmellow(AmmoAmount);
            }
            //Health "Ammo"
            else if (HealthType)
            {
                PlayerLife.Heal(AmmoAmount);
            }

            //Remove the ammo pickup from play
            Destroy(gameObject);
        }
    }


}

