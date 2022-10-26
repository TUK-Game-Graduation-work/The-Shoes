using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclesGenerator : MonoBehaviour
{
    GameObject player;
    GameObject preStone;
    public GameObject stone;
    public GameObject board;
    float delTime = 1f;

    void Start()
    {
        this.player = GameObject.Find("Player");
        this.preStone = GameObject.FindGameObjectWithTag("Stone");
    }

    void Update()
    {
        if (this.preStone.GetComponent<RollingStone>().isCollision == true)
        {
            GameObject NewStone = Instantiate(stone) as GameObject;
            this.preStone = NewStone;
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