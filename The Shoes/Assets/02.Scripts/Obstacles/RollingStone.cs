using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingStone : MonoBehaviour
{
    GameObject player;

    public bool isCollision = false;
    //생성 시점 및 소멸 시점, 굴러서 내려오는 것은 리지드바디에 맡기는 게 자연스럽긴 한 듯. 

    void Start()
    {
        this.player = GameObject.Find("Player");
    }

    void Update()
    {
        if (this.isCollision)
        {
            Destroy(gameObject);
            this.isCollision = false;
        }
        //플레이어 위치에 따라 돌 굴러내려오기 시작 및 소멸되면 다시 굴러오기.
        //이 과정은 돌을 내려보내는 역할을 맡는 스크립트가 해야 할 듯.
    }
}
