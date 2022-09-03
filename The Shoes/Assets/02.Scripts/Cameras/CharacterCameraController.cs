using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCameraController : MonoBehaviour
{
    GameObject player;

    //ȭ�� ���������� �� ������ �� ����
    float moveWidth = 3.0f;

    //���� �� ����
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
        //�÷��̾� ������ �޾ƿ���
        Vector3 playerPos = this.player.transform.position;

        //X ������
        if (playerPos.x >= maxX || playerPos.x <= minX)
        {
            maxX = playerPos.x + moveWidth;
            minX = playerPos.x - moveWidth;
            transform.position = new Vector3(
            playerPos.x, transform.position.y, transform.position.z);
        }

        //Z ������
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
 * �����̱�� ������ �ε巴�� �������� ����. ��� ������ �̴� �� �ƴϰ� �������� ���� �����༭ �׷� ��
 * ���� ���� ���ݾ� ����. �ٵ� ī�޶� force�� �̴� �� �����Ѱ� �ʹ�... �ƹ�ư �ذ��� ��!
 * <9/2_���� 1>
 * 
 * ĳ���͸� ������� ���󰡰� �ϴٰ� �� ���󰡴� '��' ���� �����ϰ� �;��µ� ��¥ ��¥ ������ �̰� �ణ
 * �ָ��ϰ� ���ڿ������� ������ ĳ���Ͱ� maxX, minX�� ������ ���� ī�޶� ĳ������ '�߽�'�� ã�ư��� ������ �ǵ�
 * �߽��� �ƴ϶� ĳ���Ͱ� �����̴¸�ŭ��,,, �� ���� ���⵵ �ָ��� ������̴�. �׸��� Ȥ�� ���� �׳� ������ ĳ���� �����ϴ� �ڵ嵵 �߰���.
 * 
 * �״ϱ� �ϰ� ������ �����ĸ� ĳ���Ͱ� ���� ��ġ���� ���� ��ġ�� ������ ���� �������� ��ȭ���� �� �� �ִٸ�
 * maxX += ��ȭ��, transform.position.x + ��ȭ�� �ؼ� ��ȭ����ŭ�� �����̰� �;���. �׷��� ī�޶� �ڿ������� �̵��� ���̰�,,,
 * <9/3_���� 2>
 */