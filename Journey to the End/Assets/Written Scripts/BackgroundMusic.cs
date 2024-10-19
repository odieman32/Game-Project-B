using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    //An attempt at making the background music not overlap with Main Menu, but did not work out
    private static BackgroundMusic backgroundMusic;

    void Awake()
    {
        if(backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

//Source: https://www.youtube.com/watch?v=U3sT-T5bKX4