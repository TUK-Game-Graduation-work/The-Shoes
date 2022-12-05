using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    /*
     1. 충돌하면 자기가 하고 싶은대로 진행하도록 만들어 오기
     2. 맵 공부 (터레인~ 축적(캐릭터(2x2x2칸) 대비 맵 크기)) 구성하는 방법, 구체적인 가이드라인 생각해오기
     3. 장애물에 닿으면 -> 캐릭터 효과+죽음 장면(이게 아니라는 걸 알려줌) -> (최근)저장 위치 리스폰
     ----------------------------------------------------------------
     현재 논외. UI Manager : pause(ESC), restart, exit 등.. 메뉴 만들기
     */

    public bool isGameOver;

    public GameObject player;
    public GameObject currCheckPoint;

    private CheckPoint checkPoint;


    void Start()
    {
        isGameOver = false;
        this.player = GameObject.Find("Player");
    }

    void Update()
    {
        this.checkPoint = FindObjectOfType<CheckPoint>();

        if (isGameOver == true)
        {
            if (checkPoint.CheckReach == true)
            {
                this.player.transform.position = checkPoint.posi;
                isGameOver = false;
            }
            else
            {
                SceneManager.LoadScene("Stage1");
                isGameOver = false;

            }
        }
    }
}
