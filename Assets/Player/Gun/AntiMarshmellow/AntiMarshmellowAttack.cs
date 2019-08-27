

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


//ANTIMARSHMELLOWATTACK
//Allows player to ACTUALLY hurt marshmellows
public class AntiMarshmellowAttack : MonoBehaviour
{

    //VARIABLES
    //Attack
    bool MarshmellowInRange = false;              //Controls whether to hurt a marshmellow
    public int AttackDamage = 80;
    //Target
    GameObject Monster;                         //Name of monster
    MonsterHealth MonsterLife;                  //Name of monster's life


    //UPDATE
    //Decide if any monsters present and whether to attack
    void Update()
    {
        //Check if any monsters are in range
        if (MarshmellowInRange)
        {
            //Projectile can harm monster
            if (MonsterLife.CurrentHealth > 0)
            {
                MonsterLife.Damage(AttackDamage);
            }
        }
    }


    //ONCOLLISIONENTER
    //Checks if something in range is a marshmellow
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == 9)
        {
            MarshmellowInRange = true;                    //Set the flag
            Monster = collision.collider.gameObject;      //Target this Marshmellow for damage
            MonsterLife = Monster.GetComponent<MonsterHealth>();
            Debug.Log("Hit a marshmellow!");                //DEBUG
        }
    }


    //ONCOLLISIONEXIT
    //Resets trigger allowing monster to attack again
    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.gameObject.layer == 10)
        {
            MarshmellowInRange = false;                   //Reset the flag
        }
    }
}

