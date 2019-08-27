

//DECLARATIONS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//MONSTERATTACK
//Deals damage to player
public class MonsterAttack : MonoBehaviour
{

    //VARIABLES
    //Attack
        public float AttackSpeed = 0.5f;
        public int AttackDamage = 10;
        bool PlayerInRange;                     //Controls attacking
        float Timer;                            //Keeps time of attacks
    //Effects
        Animator MonsterAnimator;
        MonsterHealth MonsterLife;
    //Target
        GameObject Player;
        PlayerHealth PlayerLife;


    //AWAKE
    //Assign components to variables
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerLife = Player.GetComponent<PlayerHealth>();
        MonsterLife = GetComponent<MonsterHealth>();
        MonsterAnimator = GetComponent<Animator>();
    }


    //UPDATE
    //Decide what to do
    void Update()
    {
        //Increment time each frame
        Timer += Time.deltaTime;
        //Monster can attack again
        if (Timer >= AttackSpeed && PlayerInRange && MonsterLife.CurrentHealth > 0)
        {
            Attack();
        }
        //Monster can stop looking for the player
        if (PlayerLife.CurrentHealth <= 0)
        {
            MonsterAnimator.SetTrigger("PlayerDead");
        }
    }


    //ATTACK
    //Deal damage to player
    void Attack()
    {
        //Reset Timer
        Timer = 0f;
        //Monster can damage player
        if (PlayerLife.CurrentHealth > 0)
        {
            PlayerLife.Damage(AttackDamage);
        }
    }


    //ONTRIGGERENTER
    //Checks if something in range is the player
    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject == Player)
        {
            PlayerInRange = true;
        }
    }


    //ONTRIGGEREXIT
    //Resets trigger allowing monster to attack again
    void OnTriggerExit (Collider Other)
    {
        if(Other.gameObject == Player)
        {
            PlayerInRange = false;
        }
    }


}

