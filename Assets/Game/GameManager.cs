using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;               //Added for UI Components

public class GameManager : MonoBehaviour
{

    //VARIABLES
    int Score;
    int ScoreStart = 0;
    float Timer;
    public Image DamageImage;
    public Color DamageFlashColor;
    public GameObject Player;
    PlayerHealth PlayerLife;

    // Start is called before the first frame update
    void Start()
    {
        Timer = 0f;
        PlayerLife = Player.GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= 30f)
        {
            Debug.Log("You Win!");
            //Flash Green
            DamageImage.color = DamageFlashColor;
            PlayerLife.Damage(1000);
        }
    }
}
