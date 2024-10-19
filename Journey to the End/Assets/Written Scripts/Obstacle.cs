using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //Code for the asteroids
    private GameObject player;

    //Finds the Player Game object by tag
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    //Causes the Player to be destroyed when hit and the asteroids to be destoryed when hit by border
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {
            Destroy(player.gameObject);
        }
    }
}

//Source: https://www.youtube.com/watch?v=U3sT-T5bKX4 by Hooson
