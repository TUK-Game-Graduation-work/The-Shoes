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

    void Start()
    {
        isGameOver = false;
    }

    void Update()
    {
        if (isGameOver == true)
        {
            //������Ʈ �Լ� ���� + ���߿��� ���� ������ �� ����
            SceneManager.LoadScene("Stage1");
            return;

        }
    }
}
