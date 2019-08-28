

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
//using UnityEngine.UI;               //Added for UI Components


//PLAYERATTACK
//Allows player to hurt monsters
public class PlayerAttack : MonoBehaviour
{

    //VARIABLES

        //Gun
        public float FireTime = 0.33f;              //How fast the gun fires
        public Transform GunBarrel;                 //Where the projectiles come from
        public float FireForce = 1000f;               //How hard to throw projectiles
        private float FireTimer;                    //Controls when to fire
    
        //Projectile
        public float ProjectileLifetime = 5f;       //Controls when to despawn projectiles
        public GameObject AntiCracker;              //AntiCracker Projectile
        public GameObject AntiChocolate;            //AntiChocolate Projectile
        public GameObject AntiMarshmellow;          //AntiMarshmellow Projectile
    
        //Effects
        public int Damage = 10;                     //Controls how much damage to do
        GameObject Monster;                         //What we hurt
        AudioSource PlayerSound;
        public AudioClip PainClip;                  //Plays if player hurts
        public AudioClip FireClip;                  //Plays if player fires
        //public AudioClip JamClip;                   //Plays if empty ammo
    
        //Ammo
        bool AntiCrackerMode = true;                //Controls whether gun can fire anticrackers
        bool AntiChocolateMode = true;              //Controls whether gun can fire anticrackers
        bool AntiMarshmellowMode = true;            //Controls whether gun can fire anticrackers


    //AWAKE
    //Assigns masks and effects
    void Awake()
    {
        //Reset Timer
        FireTimer = 0f;
        //Set Sound Source
        PlayerSound = GetComponent<AudioSource>();
    }


    //UPDATE
    //Decides if player can fire
    void Update()
    {
        //Decrement Timer as time passes
        FireTimer -= Time.deltaTime;

        //Check if player can and wants to fire which mode
        //AntiMarshmellow Fire
        if (Input.GetMouseButton(0) && (FireTimer <= 0f) && AntiMarshmellowMode)
        {
            AntiMarshmellowFire();
            PlayerSound.clip = FireClip;           //Change Sound to Fire
            PlayerSound.Play();
            PlayerSound.clip = PainClip;           //Change Sound to Pain
        }
        //AntiCracker Fire
        else if (Input.GetMouseButton(1) && (FireTimer <= 0f) && AntiCrackerMode)
        {
            AntiCrackerFire();
            PlayerSound.clip = FireClip;           //Change Sound to Fire
            PlayerSound.Play();
            PlayerSound.clip = PainClip;           //Change Sound to Pain
        }
        //AntiChocolate Fire
        else if (Input.GetMouseButton(2) && (FireTimer <= 0f) && AntiChocolateMode)
        {
            AntiChocolateFire();
            PlayerSound.clip = FireClip;           //Change Sound to Fire
            PlayerSound.Play();
            PlayerSound.clip = PainClip;           //Change Sound to Pain
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

