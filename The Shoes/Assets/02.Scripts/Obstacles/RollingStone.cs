using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingStone : MonoBehaviour
{
    GameObject player;

    public bool isCollision = false;
    //���� ���� �� �Ҹ� ����, ������ �������� ���� ������ٵ� �ñ�� �� �ڿ������� �� ��. 

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
        //�÷��̾� ��ġ�� ���� �� ������������ ���� �� �Ҹ�Ǹ� �ٽ� ��������.
        //�� ������ ���� ���������� ������ �ô� ��ũ��Ʈ�� �ؾ� �� ��.
    }
}
