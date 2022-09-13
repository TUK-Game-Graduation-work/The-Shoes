using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclesGenerator : MonoBehaviour
{
    public GameObject stone;
    GameObject player;
    GameObject preStone;

    public void makeStone()
    {
        if (this.preStone.GetComponent<RollingStone>().isCollision == true)
        {
            GameObject NewStone = Instantiate(stone) as GameObject;
            this.preStone = NewStone;
            this.player.GetComponent<PlayerMove>().stone = NewStone;
        }
    }
    void Start()
    {
        this.player = GameObject.Find("Player");
        this.preStone = GameObject.Find("RollingStone");
    }

    void Update()
    {
        makeStone();
    }
}
