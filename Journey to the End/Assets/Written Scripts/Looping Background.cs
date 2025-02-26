using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    //This code loops the background infinitely with the camera movement
    [SerializeField] float backgroundSpeed;
    [SerializeField] Renderer backgroundRenderer;
   

    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}

//Source: https://www.youtube.com/watch?v=U3sT-T5bKX4 by Hooson
