using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ClosingRock : MonoBehaviour
{
    public GameManager gameManager;
    GameObject player = null;

    //ĳ���� ���� ���� ����/������
    public bool isReftRock = true;
    //�����ִ��� �����ִ���
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
 ��ǥ
1. �ð� ������ �ΰ� ���ȴ�, ������ �ؾ��Ѵ�.
2. �αٿ� �ִ� �������� ���� �������� �����̸� �ȵȴ�.
3. �÷��̾ ������ �ٰ����� �۵��Ѵ�. �����Ÿ� �־����� �ʱ�ȭ Ȥ�� ����

HOW?
�ϴ� ������ �Ǵ� �� ���� ������ �ϳ��� ������ �����δ�.
�ѽֿ� ���� ��ȣ�� �ο��Ѵ�. ������ �ִ� ���� ��� 
1,2,3,4... Ȧ�� ¦���� ���� �� �ְԵȴ�.

�� ���� deltaTime�� ���� �۵��Ǵ� �ð��� �����ϰ� �ǰ� 
�����̴� ������ ������ �̿��� ����, ����� ���� ���� �̵� ��Ų��.

���� ������ in /out �� �˷��ִ� boolean ������ ���� �������� ���� �޴´�.

 */  