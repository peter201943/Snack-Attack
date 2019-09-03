

//DECLARATIONS
//Imports names and objects
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


//MONSTERMOVEMENT
//Moves Monsters
public class MonsterMovement : MonoBehaviour
{

    //VARIABLES
    //What the monster moves toward
    Transform Player;
    //What the monster is
    NavMeshAgent Monster;
    //When the monster can move
    public float SpawnTime = 2f;
    //Monster move timer
    private float SpawnTimer = 0f;


    //AWAKE
    //Awake is called regardless of assignment
    //Finds Player and Map
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        Monster = GetComponent<NavMeshAgent>();
    }


    //UPDATE
    //Update is called once per frame
    //Tells the Monster where Player is
    void Update()
    {
        //Can Move
        if (SpawnTimer >= SpawnTime)
        { 
            Monster.SetDestination(Player.position);
        }
        //Cannot Move
        else
        {
            SpawnTimer += Time.deltaTime;
        }
    }
}
