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
 * delTime == 나무판자가 생성되는 쿨타임 설정.
 * player의 위치가 일정 위치에 도달하면 판자 생성 쿨타임 진행.
 */