using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //This Script has the camera moving to the right 
    [SerializeField] float cameraSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}

//Source: https://www.youtube.com/watch?v=U3sT-T5bKX4
