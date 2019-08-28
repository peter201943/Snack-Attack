

//DECLARATIONS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;               //Added for UI Components


//GAMEMANAGER
//Overglorified popup box
public class GameManager : MonoBehaviour
{

    //VARIABLES
    private int MonstersRemaining;              //Controls game win
    private GameObject[] Monsters;              //Tracks remaining monsters
    public float Wait = 5f;                     //Controls when to start scoring


    //UPDATE
    //Has player won yet?
    void Update()
    {
        //Decrement Wait Period
        Wait -= Time.deltaTime;
        //Find Monsters
        GameObject[] Monsters = GameObject.FindGameObjectsWithTag("Monster");
        //Count Monsters
        MonstersRemaining = Monsters.Length;
        //Is it over yet?
        //Yes
        if ((MonstersRemaining <= 5) && (Wait <= 0f))
        {
            Debug.Log("You Win");
            GUI.Label(new Rect(0, 0, 200, 20), "YOU WIN");
        }
    }
}

