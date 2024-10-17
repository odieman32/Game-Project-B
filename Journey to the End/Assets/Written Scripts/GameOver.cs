using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject pauseButton;

    // Update is called once per frame
    void Update()
    {
        //Finds the Player game object through the Player tag
        if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            //sets the game over UI active
            gameOver.SetActive(true);
            //Turns off pause button
            pauseButton.SetActive(false);
        }
    }
   
    //Reloads the scene 
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        //Loads the main menu
        SceneManager.LoadScene(0);

    }
}

//Source: https://www.youtube.com/watch?v=U3sT-T5bKX4
