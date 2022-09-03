using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCameraController : MonoBehaviour
{
    GameObject player;

    //화면 정지상태일 때 움직임 폭 설정
    float moveWidth = 3.0f;

    //기초 폭 설정
    float maxX = 3.0f;
    float minX = -3.0f;
    float maxZ = 0.5f;
    float minZ = -5.5f;

    void Start()
    {
        this.player = GameObject.Find("Player");
    }

    void Update()
    {
        //플레이어 포지션 받아오기
        Vector3 playerPos = this.player.transform.position;

        //X 움직임
        if (playerPos.x >= maxX || playerPos.x <= minX)
        {
            maxX = playerPos.x + moveWidth;
            minX = playerPos.x - moveWidth;
            transform.position = new Vector3(
            playerPos.x, transform.position.y, transform.position.z);
        }

        //Z 움직임
        if (playerPos.z - 2.5f >= maxZ || playerPos.z - 2.5f <= minZ)
        {
            maxZ = playerPos.z - 2.5f + moveWidth;
            minZ = playerPos.z - 2.5f - moveWidth;
            transform.position = new Vector3(
            transform.position.x, transform.position.y, playerPos.z - 2.5f);
        }

        //transform.position = new Vector3(playerPos.x, playerPos.y + 3.5f, playerPos.z - 2.5f);

    }
}

/*
 * 움직이기는 하지만 부드럽게 움직이지 않음. 얘는 힘으로 미는 게 아니고 포지션을 딱딱 정해줘서 그런 것
 * 같은 감이 없잖아 있음. 근데 카메라도 force로 미는 게 가능한가 싶다... 아무튼 해결은 함!
 * <9/2_수정 1>
 * 
 * 캐릭터를 어느정도 따라가게 하다가 안 따라가는 '그' 것을 구현하고 싶었는데 진짜 진짜 빡세다 이게 약간
 * 애매하게 부자연스러운 느낌이 캐릭터가 maxX, minX를 지나는 순간 카메라가 캐릭터의 '중심'을 찾아가서 문제인 건데
 * 중심이 아니라 캐릭터가 움직이는만큼만,,, 참 말로 적기도 애매한 어려움이다. 그리고 혹시 몰라 그냥 무작정 캐릭터 추적하는 코드도 추가함.
 * 
 * 그니까 하고 싶은게 뭐였냐면 캐릭터가 이전 위치에서 현재 위치로 움직일 때의 움직임의 변화량을 알 수 있다면
 * maxX += 변화량, transform.position.x + 변화량 해서 변화량만큼만 움직이고 싶었음. 그러면 카메라도 자연스럽게 이동할 것이고,,,
 * <9/3_수정 2>
 */