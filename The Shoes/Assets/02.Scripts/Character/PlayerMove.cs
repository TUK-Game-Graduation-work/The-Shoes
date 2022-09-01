using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float moveSpeed = 10f;
    public float jumpPower = 10f;

    private bool isJumping = false;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //playerRigidbody.AddForce(Vector3.down * forceGravity);

        if (Input.GetKey(KeyCode.W))
            playerRigidbody.AddForce(0, 0, moveSpeed);
        if (Input.GetKey(KeyCode.A))
            playerRigidbody.AddForce(-moveSpeed, 0, 0);
        if (Input.GetKey(KeyCode.S))
            playerRigidbody.AddForce(0, 0, -moveSpeed);
        if (Input.GetKey(KeyCode.D))
            playerRigidbody.AddForce(moveSpeed, 0, 0);
        jump();

        
    }

    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
                playerRigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            
        }
    }
}
