using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Code for Player
    [SerializeField] float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    
    //Gets players rigidbody
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //Gets player input of W and S
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    }
    
    //Sets player Speed
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}

//https://www.youtube.com/watch?v=U3sT-T5bKX4 by Hooson
