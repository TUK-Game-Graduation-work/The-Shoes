using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameManager gameManager;
    private Rigidbody playerRigidbody;
    public float moveSpeed = 0.5f;
    public float jumpPower = 10.0f;
    public char inputKey = 'W';
    public GameObject Boomernag;

    public bool isAttack = false;
    private bool isJumping = false; //점프 상태 확인
    private int jumpCount = 2;      //점프 횟수 변경시 값 변경

    void Start()
    {
        jumpCount = 0;
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Debug.Log(Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
        {
            inputKey = 'W';
            playerRigidbody.AddForce(0, 0, moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerRigidbody.AddForce(-moveSpeed, 0, 0);
            inputKey = 'A';
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRigidbody.AddForce(0, 0, -moveSpeed);
            inputKey = 'S';
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerRigidbody.AddForce(moveSpeed, 0, 0);
            inputKey = 'D';
        }
        if (Input.GetKey(KeyCode.E))
        {
            if(isAttack != true)
            {
                Debug.Log("E");
                GameObject NewBoomerang = Instantiate(Boomernag) as GameObject;
            }
            isAttack = true;
        }

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
        //물에 닿았을 때  
        if (collision.gameObject.CompareTag("Water"))
        {
            gameManager.isGameOver = true;
        }
        //굴러오는 돌에 닿았을 때  
        if (collision.gameObject.CompareTag("Stone"))
        {
            collision.gameObject.GetComponent<RollingStone>().isCollision = true; //충돌을 알림.
        }

        //가시에 닿았을 때
        if (collision.gameObject.CompareTag("Spine"))
        {
            collision.gameObject.GetComponent<Spine>().isCollision = true; //충돌을 알림.
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
