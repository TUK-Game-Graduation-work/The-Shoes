using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclesGenerator : MonoBehaviour
{
    GameObject player;
    GameObject preStone;
    public GameObject stone;

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
    }
}
