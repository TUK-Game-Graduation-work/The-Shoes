using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float moveSpeed = 0.5f;
    public float jumpPower = 10.0f;

    private bool isJumping = false; //점프 상태 확인
    private int jumpCount = 2;      //점프 횟수 변경시 값 변경

    public GameObject stone; //stone 객체 받아오기 위함.

    void Start()
    {
        jumpCount = 0;
        playerRigidbody = GetComponent<Rigidbody>();
        this.stone = GameObject.Find("RollingStone");
    }

    void Update()
    {
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
    void OnCollisionEnter(Collision collision)
    {
        //바닥에 닿았을 때(Ground tag를 가진 물체에 닿았을 때)     
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            jumpCount = 2;
        }

        //굴러오는 돌에 닿았을 때  
        if (collision.gameObject.CompareTag("Stone"))
        {
            //Debug.Log("돌에 맞음");
            this.stone.GetComponent<RollingStone>().isCollision = true; //충돌을 알림.
        }

        //가시에 닿았을 때
        if (collision.gameObject.CompareTag("Spine") || collision.gameObject.CompareTag("Water"))
        {
            Debug.Log("가시에 닿음");
        }
    }

    void jump()
    {
        //점프 상태가 아니고 점프 카운트가 남아있을 때 실행
        if (!isJumping && jumpCount > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerRigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
                jumpCount--;

            }
        }
    }
}
