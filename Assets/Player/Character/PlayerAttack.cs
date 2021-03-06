﻿

//NOTES
/*
 * Nowhere in this script is damage done.
 * This is a LAUNCHER script
 * The DAMAGE script is attached to the projectiles
 * The projectiles can detect if they hit the right monster
 * See the individual projectiles for their scripts
*/


//DECLARATIONS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;               //Added for UI Components
using TMPro;                        //Added for Text Mesh Components


//PLAYERATTACK
//Allows player to hurt monsters
public class PlayerAttack : MonoBehaviour
{

    //VARIABLES

        //Gun
        public float FireTime = 0.33f;                  //How fast the gun fires
        public Transform GunBarrel;                     //Where the projectiles come from
        public float FireForce = 1500f;                 //How hard to throw projectiles
        private float FireTimer;                        //Controls when to fire
        private bool AntiMarshmellowDisplay = false;    //Controls UI Image
        private bool AntiChocolateDisplay = false;      //Controls UI Image
        private bool AntiCrackerDisplay = false;        //Controls UI Image

        //Projectile
        public float ProjectileLifetime = 5f;           //Controls when to despawn projectiles
        public GameObject AntiCracker;                  //AntiCracker Projectile
        public GameObject AntiChocolate;                //AntiChocolate Projectile
        public GameObject AntiMarshmellow;              //AntiMarshmellow Projectile
    
        //Target and Inventory
        GameObject Monster;                             //What we hurt
        PlayerInventory PlayerAmmo;                     //Where we get ammo from

        //Audio
        AudioSource PlayerSound;
        public AudioClip PainClip;                      //Plays if player hurts
        public AudioClip FireClip;                      //Plays if player fires
        //public AudioClip JamClip;                     //Plays if empty ammo

        //UI
        public TextMeshProUGUI WeaponTypeDisplay;       //Shows weapon mode to player
        public Image WeaponModeDisplay;                 //Shows image of weapon mode to player
    
        //Ammo
        bool AntiCrackerMode = true;                    //Controls whether gun can fire anticrackers
        bool AntiChocolateMode = true;                  //Controls whether gun can fire anticrackers
        bool AntiMarshmellowMode = true;                //Controls whether gun can fire anticrackers


    //AWAKE
    //Assigns masks and effects
    void Awake()
    {
        //Reset Timer
        FireTimer = 0f;
        //Set Sound Source
        PlayerSound = GetComponent<AudioSource>();
        //Set Default Fire Display
        AntiMarshmellowDisplay = true;
        //Find Inventory
        PlayerAmmo = GetComponent<PlayerInventory>();
    }


    //UPDATE
    //Decides if player can fire and updates UI
    void Update()
    {
        //Decrement Timer as time passes
        FireTimer -= Time.deltaTime;

        //Check if player can and wants to fire which mode
        //AntiMarshmellow Fire
        if (Input.GetMouseButton(0) && (FireTimer <= 0f) && AntiMarshmellowMode)
        {
            //ACTION
            AntiMarshmellowFire();
            //UI
            WeaponTypeDisplay.text = "Choc+Crack";      //Update UI
            //INVENTORY
            PlayerAmmo.DropChocolate(1);                //Expend a Chocolate
            PlayerAmmo.DropCracker(1);                  //Expend a Cracker
            //AUDIO
            PlayerSound.clip = FireClip;                //Change Sound to Fire
            PlayerSound.Play();                         //Boom!
            PlayerSound.clip = PainClip;                //Change Sound to Pain
        }
        //AntiCracker Fire
        else if (Input.GetMouseButton(1) && (FireTimer <= 0f) && AntiCrackerMode)
        {
            //ACTION
            AntiCrackerFire();
            //UI
            WeaponTypeDisplay.text = "Marsh+Choc";      //Update UI
            //INVENTORY
            PlayerAmmo.DropChocolate(1);                //Expend a Chocolate
            PlayerAmmo.DropMarshmellow(1);              //Expend a Marshmellow
            //AUDIO
            PlayerSound.clip = FireClip;                //Change Sound to Fire
            PlayerSound.Play();                         //Boom!
            PlayerSound.clip = PainClip;                //Change Sound to Pain
        }
        //AntiChocolate Fire
        else if (Input.GetMouseButton(2) && (FireTimer <= 0f) && AntiChocolateMode)
        {
            //ACTION
            AntiChocolateFire();
            //UI
            WeaponTypeDisplay.text = "Marsh+Crack";     //Update UI
            //INVENTORY
            PlayerAmmo.DropMarshmellow(1);              //Expend a Marshmellow
            PlayerAmmo.DropCracker(1);                  //Expend a Cracker
            //AUDIO
            PlayerSound.clip = FireClip;                //Change Sound to Fire
            PlayerSound.Play();                         //Boom!
            PlayerSound.clip = PainClip;                //Change Sound to Pain
        }

    }


    //ANTIMARSHMELLOWFIRE
    //Lobs a projectile at the enemy
    void AntiMarshmellowFire()
    {
        GameObject CurrentProjectile = (GameObject)Instantiate(AntiMarshmellow, GunBarrel.position, GunBarrel.rotation);
        CurrentProjectile.GetComponent<Rigidbody>().AddForce(GunBarrel.up * FireForce);
        Destroy(CurrentProjectile, ProjectileLifetime);
        FireTimer = FireTime;
    }


    //ANTICHOCOLATEFIRE
    //Lobs a projectile at the enemy
    void AntiChocolateFire()
    {
        GameObject CurrentProjectile = (GameObject)Instantiate(AntiChocolate, GunBarrel.position, GunBarrel.rotation);
        CurrentProjectile.GetComponent<Rigidbody>().AddForce(GunBarrel.up * FireForce);
        Destroy(CurrentProjectile, ProjectileLifetime);
        FireTimer = FireTime;
    }


    //ANTICRACKERFIRE
    //Lobs a projectile at the enemy
    void AntiCrackerFire()
    {
        GameObject CurrentProjectile = (GameObject)Instantiate(AntiCracker, GunBarrel.position, GunBarrel.rotation);
        CurrentProjectile.GetComponent<Rigidbody>().AddForce(GunBarrel.up * FireForce);
        Destroy(CurrentProjectile, ProjectileLifetime);
        FireTimer = FireTime;
    }

}

