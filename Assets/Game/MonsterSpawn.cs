

//DECLARATIONS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//MONSTERSPAWN
//Controls activation and instatntion of monsters
public class MonsterSpawn : MonoBehaviour
{

    //VARIABLES

        //Spawnsters
        public GameObject MarshmellowMonster;
        public GameObject CrackerMonster;
        public GameObject ChocolateMonster;

        //Logic
        private float SpawnTimer;
        public float SpawnTime = 1f;
        private bool CanSpawn = false;

        //Spawn Placement
        public Transform[] SpawnLocations;
        private Transform SpawnLocation;
        private int SpawnCount = 0;


    //AWAKE
    //???
    void Awake()
    {
        SpawnTimer = 2f;
    }


    //GETSPAWNLOCATION
    //Picks a spawn
    void GetSpawnLocation()
    {
        //Do we reset?
        //Yes
        if (SpawnCount >= SpawnLocations.Length)
        {
            SpawnCount = 0;
        }
        //Set spawn
        SpawnLocation = SpawnLocations[SpawnCount];
        //Go to next spawn location
        SpawnCount += 1;
    }


    //UPDATE
    //Checks if we can spawn yet
    void Update()
    {
        //Decrement Timer
        SpawnTimer -= Time.deltaTime;
        //Can we spawn?
        //Yes
        if ((SpawnTimer <= 0f) && CanSpawn)
        {
            //Pick a Spawn Location
            GetSpawnLocation();

            //Spawn a Smore
            //Crack + Marsh + Choc
            Instantiate(MarshmellowMonster, SpawnLocation.position, Quaternion.identity);
            Instantiate(CrackerMonster, SpawnLocation.position, Quaternion.identity);
            Instantiate(ChocolateMonster, SpawnLocation.position, Quaternion.identity);

            //Reset Spawn
            SpawnTimer = SpawnTime;
        }
        //First spawn
        else if (SpawnTimer <= 0f)
        {
            //Let the evil begin!
            CanSpawn = true;
        }
        //No
    }
}

