

//NOTES
/*
 * Layer 9 is Marshmellow
 * Layer 10 is Chocolate
 * Layer 11 is Cracker
 */


//DECLARATIONS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ANTICHOCOLATEATTACK
//Allows player to ACTUALLY hurt chocolates
public class AntiChocolateAttack : MonoBehaviour
{

    //VARIABLES
    //Attack
        bool ChocolateInRange = false;              //Controls whether to hurt a chocolate
        public int AttackDamage = 80;
    //Target
        GameObject Monster;                         //Name of monster
        MonsterHealth MonsterLife;                  //Name of monster's life


    //UPDATE
    //Decide if any monsters present and whether to attack
    void Update()
    {
        //Check if any monsters are in range
        if (ChocolateInRange)
        {
            //Projectile can harm monster
            if (MonsterLife.CurrentHealth > 0)
            {
                MonsterLife.Damage(AttackDamage);
            }
        }
    }


    //ONCOLLISIONENTER
    //Checks if something in range is a chocolate
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == 10)
        {
            ChocolateInRange = true;                    //Set the flag
            Monster = collision.collider.gameObject;    //Target this Chocolate for damage
            MonsterLife = Monster.GetComponent<MonsterHealth>();
            Debug.Log("Hit a chocolate!");                //DEBUG
        }
    }


    //ONCOLLISIONEXIT
    //Resets trigger allowing monster to attack again
    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.gameObject.layer == 10)
        {
            ChocolateInRange = false;                   //Reset the flag
        }
    }
}
