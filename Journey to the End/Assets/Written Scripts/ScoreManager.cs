using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //Code for score
    [SerializeField] Text scoreText;
    private float score;

    //Creates a continuously rising score as each second passes
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }
    }
}

//Source: https://www.youtube.com/watch?v=U3sT-T5bKX4 by Hooson