

//DECLARATIONS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


//MONSTERATTACK
//Deals damage to player
public class SmoreAttack : MonoBehaviour
{

    //VARIABLES
    //Attack
        public float AttackSpeed = 0.5f;
        public int AttackDamage = -10;
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
        MonsterAnimator = GetComponent<Animator>();
    }


    //UPDATE
    //Decide what to do
    void Update()
    {
        //Increment time each frame
        Timer += Time.deltaTime;
        //Monster can attack again
        if (Timer >= AttackSpeed && PlayerInRange)
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
            GetComponent<NavMeshAgent>().enabled = false;       //Stop movings
            Destroy(gameObject);                            //Remove the monster after falling for 2 seconds
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

