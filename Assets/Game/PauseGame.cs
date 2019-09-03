

//DECLARATIONS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//PAUSEGAME
//In Game Pause Menu
public class PauseGame : MonoBehaviour
{

    //VARIABLES
    public Transform pauseCanvas;
    public Transform player;
    public Transform restartBox;
    public Transform quitBox;
    public Transform controlScreen;
    //FIX: added ref to player
    //public GameObject player;


    //UPDATE
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(restartBox.gameObject.activeInHierarchy == true)
            {
                restartBox.gameObject.SetActive(false);
            }
            else if (quitBox.gameObject.activeInHierarchy == true)
            {
                quitBox.gameObject.SetActive(false);
            }
            else if (controlScreen.gameObject.activeInHierarchy == true)
            {
                controlScreen.gameObject.SetActive(false);
            }
            else
            {
                Pause();
            }
        }
    }


    //PAUSE
    //Effects for opening menu
    public void Pause()
    {
        if (pauseCanvas.gameObject.activeInHierarchy == false)
        {
            pauseCanvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            player.GetComponent<PlayerAttack>().enabled = false;
        }
        else
        {
            pauseCanvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            player.GetComponent<PlayerAttack>().enabled = true;
        }
    }


    //CALLCONTROLS
    public void CallControls()
    {
        if (controlScreen.gameObject.activeInHierarchy == false)
        {
            controlScreen.gameObject.SetActive(true);
        }
        else
        {
            controlScreen.gameObject.SetActive(false);
        }
    }


    //CALLRESTART
    public void CallRestart()
    {
        if (restartBox.gameObject.activeInHierarchy == false)
        {
            restartBox.gameObject.SetActive(true);
        }
        else
        {
            restartBox.gameObject.SetActive(false);
        }
    }


    //RESTARTGAME
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
        Time.timeScale = 1;
    }


    //CALLQUIT
    public void CallQuit()
    {
        if (quitBox.gameObject.activeInHierarchy == false)
        {
            quitBox.gameObject.SetActive(true);
        }
        else
        {
            quitBox.gameObject.SetActive(false);
        }
    }


    //QUITTOMENU
    public void QuitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

