

//DECLARATIONS
//Added AI for navmesh control
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


//MONSTERHEALTH
//Allows monsters to die
public class MonsterHealth : MonoBehaviour
{

    //VARIABLES
    //Logic
        public int StartHealth = 100;               //Health of Monster
        public int CurrentHealth;                   //Tracks health of Monster
        bool IsDead;                                //Controls activity of monster
        bool IsFalling;                             //Controls despawning of monster
        public int Points = 10;                     //Controls score player receives
    //Effects
        public AudioClip DeathClip;
        public float FallSpeed = 2.5f;              //Speed monster despawns
        Animator MonsterAnimator;
        AudioSource MonsterAudio;
        Collider MonsterCollider;


    //AWAKE
    //Assignments and Initials
    void Awake()
    {
        //Bind Components
        MonsterAnimator = GetComponent<Animator>();
        MonsterAudio = GetComponent<AudioSource>();
        MonsterCollider = GetComponent<Collider>();
        //Set Health
        CurrentHealth = StartHealth;
    }


    //UPDATE
    //Remove the monster from play
    void Update()
    {
        //The monster is to be removed
        //For now it sinks
        if(IsFalling)
        {
            transform.Translate(-Vector3.up * FallSpeed * Time.deltaTime);
        }
    }


    //DAMAGE
    //Harms the monster
    public void Damage(int DamageSize)
    {
        //Don't beat a dead horse
        if (IsDead)
            return;
        //Deduct health
        CurrentHealth -= DamageSize;
        //Effects
        MonsterAudio.Play();
        Debug.Log("Ow!");
        //Check if monster dies
        if (CurrentHealth <= 0)
        {
            Die();
        }
    }


    //DIE
    //Deactivate the monster
    void Die()
    {
        IsDead = true;
        MonsterCollider.isTrigger = true;
        MonsterAnimator.SetTrigger("Dead");
        MonsterAudio.clip = DeathClip;              //Set Sound to Death Scream
        MonsterAudio.Play();                        //Scream to death
        Debug.Log("Augh!");
        StartDespawn();
    }


    //STARTDESPAWN
    //Set Conditions for despawning
    public void StartDespawn()
    {
        GetComponent<NavMeshAgent>().enabled = false;       //Stop moving
        GetComponent<Rigidbody>().isKinematic = true;       //Set object to moveable
        IsFalling = true;                                   //Begin despawn
        //GameManager.Score += Points;                      //Add Kill to Score
        Destroy(gameObject, 2f);                            //Remove the monster after falling for 2 seconds
    }
}

