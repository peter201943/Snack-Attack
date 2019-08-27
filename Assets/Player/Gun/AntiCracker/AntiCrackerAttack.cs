

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


//ANTICRACKERATTACK
//Allows player to ACTUALLY hurt chocolates
public class AntiCrackerAttack : MonoBehaviour
{

    //VARIABLES
    //Attack
    bool CrackerInRange = false;              //Controls whether to hurt a cracker
    public int AttackDamage = 80;
    //Target
    GameObject Monster;                         //Name of monster
    MonsterHealth MonsterLife;                  //Name of monster's life


    //UPDATE
    //Decide if any monsters present and whether to attack
    void Update()
    {
        //Check if any monsters are in range
        if (CrackerInRange)
        {
            //Projectile can harm monster
            if (MonsterLife.CurrentHealth > 0)
            {
                MonsterLife.Damage(AttackDamage);
            }
        }
    }


    //ONCOLLISIONENTER
    //Checks if something in range is a cracker
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == 11)
        {
            CrackerInRange = true;                      //Set the flag
            Monster = collision.collider.gameObject;    //Target this Cracker for damage
            MonsterLife = Monster.GetComponent<MonsterHealth>();
            Debug.Log("Hit a cracker!");                //DEBUG
        }
    }


    //ONCOLLISIONEXIT
    //Resets trigger allowing monster to attack again
    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.gameObject.layer == 11)
        {
            CrackerInRange = false;                   //Reset the flag
        }
    }
}

