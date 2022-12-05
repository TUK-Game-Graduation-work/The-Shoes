using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    /*
     1. �浹�ϸ� �ڱⰡ �ϰ� ������� �����ϵ��� ����� ����
     2. �� ���� (�ͷ���~ ����(ĳ����(2x2x2ĭ) ��� �� ũ��)) �����ϴ� ���, ��ü���� ���̵���� �����ؿ���
     3. ��ֹ��� ������ -> ĳ���� ȿ��+���� ���(�̰� �ƴ϶�� �� �˷���) -> (�ֱ�)���� ��ġ ������
     ----------------------------------------------------------------
     ���� ���. UI Manager : pause(ESC), restart, exit ��.. �޴� �����
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
