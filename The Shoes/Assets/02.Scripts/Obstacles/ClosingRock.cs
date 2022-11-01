using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ClosingRock : MonoBehaviour
{
    public GameManager gameManager;
    GameObject player = null;

    //캐릭터 시점 기준 왼쪽/오른쪽
    public bool isReftRock = true;
    //닫혀있는지 열려있는지
    public bool isClosed = true;
    bool moveSwitch = true;

    public float moveDistance = 3;
    public float moveSpeed = 1;

    float currTime = 0;
    float moveTime = 0;

    Vector3 position;

    void MoveSwitch()
    {
        if (moveSwitch)
            moveSwitch = false;
        else
            moveSwitch = true;
    }

    void ChangeDir()
    {
        //if (moveSwitch){     }
        if (isClosed)
            isClosed = false;
        else
            isClosed = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.isGameOver = true;

        }
    }

    void Start()
    {
        player = GameObject.Find("Player");
        moveTime = (moveDistance / moveSpeed);
        position = transform.position;
    }

    void Update()
    {
        currTime += Time.deltaTime;
        if (currTime > moveTime)
        {
            //Invoke("MoveSwitch", moveTime);
            //Debug.Log("!!");
            ChangeDir();
            currTime = 0;
        }

        if (moveSwitch)
        {
            if (isClosed)
            {
                if (isReftRock)
                {
                    position.z += moveSpeed * Time.deltaTime;
                }
                else
                {
                    position.z -= moveSpeed * Time.deltaTime;
                }
                transform.position = position;
                //Debug.Log("Open");
            }

            else if (!isClosed)
            {
                if (isReftRock)
                {
                    position.z -= moveSpeed * Time.deltaTime;
                }
                else
                {
                    position.z += moveSpeed * Time.deltaTime;
                }
                transform.position = position;
                //Debug.Log("Close");
            }
        }
    }
}

/*
 목표
1. 시간 간격을 두고 열렸다, 닫혔다 해야한다.
2. 인근에 있는 바위블럭은 같은 방향으로 움직이면 안된다.
3. 플레이어가 가까이 다가가면 작동한다. 일정거리 멀어지면 초기화 혹은 멈춤

HOW?
일단 닫히게 되는 두 개의 바위가 하나의 쌍으로 움직인다.
한쌍에 개별 번호를 부여한다. 놓여져 있는 순서 대로 
1,2,3,4... 홀수 짝수로 나눌 수 있게된다.

한 쌍은 deltaTime을 통해 작동되는 시간만 공유하게 되고 
움직이는 방향은 변수를 이용해 음수, 양수를 더해 따로 이동 시킨다.

개별 돌들은 in /out 을 알려주는 boolean 변수를 통해 움직임을 지시 받는다.

 */  