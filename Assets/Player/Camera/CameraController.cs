

//DECLARATIONS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//CAMERACONTROLLER
//Cuts camera to next area on entering trigger area
public class CameraController : MonoBehaviour
{

    //VARIABLES
    //Sensing
        public GameObject Player;                           //The Player to follow
        public GameObject CameraTriggers;                   //The Triggers to monitor - Must be set in editor
    //Moving
        public GameObject CameraPositions;                  //The Positions to cut to - must be set in editor
        public GameObject StartPosition;                    //The first position for the camera - Must be set in editor
        GameObject CameraPosition;                          //The Current Position
        GameObject NextPosition;                            //The Position to cut to


    //AWAKE
    //Find and bind camera, player, triggers
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        //NextPosition = StartPosition;
        //Move();
    }


    //UPDATE
    //Check if any triggers where set and which ones
    void Update()
    {
        //Scan for triggers
        //CheckTriggers();
        transform.position = new Vector3(Player.transform.position.x, 30, Player.transform.position.z - 20);   //change 10 with desired distance from player
    }


    //CHECKTRIGGERS
    //Check that player has not entered a new area
    void CheckTriggers()
    {
        //Iterate through Triggers in List

            //Check if player has entered trigger

                //Find trigger's camera position

                //Move to new position

    }


    //MOVE
    //Moves camera to new position on trigger
    void Move()
    {
        CameraPosition = NextPosition;
        gameObject.transform.position = NextPosition.transform.position;
    }


}

