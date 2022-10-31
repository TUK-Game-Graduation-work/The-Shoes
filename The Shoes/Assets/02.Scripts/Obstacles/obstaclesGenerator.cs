using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclesGenerator : MonoBehaviour
{
    GameObject player;
    public GameObject stone;
    public GameObject board;
    float delTime = 1f;
    float StonedelTime = 1f;

    void Start()
    {
        this.player = GameObject.Find("Player");
    }

    void Update()
    {
        if (StonedelTime >= 8f)
        {
            GameObject NewStone = Instantiate(stone) as GameObject;
            StonedelTime = 0f;
        }
        else
        {
            StonedelTime += Time.deltaTime;
        }

        if (this.player.transform.position.x <= -45f && this.player.transform.position.z >= 16f)
        {
            if (delTime >= 1f)
            {
                GameObject NewBoard = Instantiate(board) as GameObject;
                delTime = 0f;
            }
            else
            {
                delTime += Time.deltaTime;
            }
        }
    }
}

/*
 * delTime == �������ڰ� �����Ǵ� ��Ÿ�� ����.
 * player�� ��ġ�� ���� ��ġ�� �����ϸ� ���� ���� ��Ÿ�� ����.
 */