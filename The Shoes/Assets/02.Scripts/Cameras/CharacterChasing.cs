using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChasing : MonoBehaviour
{
    // GameObject player;
    public GameObject Target;

    //ī�޶� ��ǥ
    public float offsetX = 0.0f;
    public float offsetY = 10.0f;
    public float offsetZ = -10.0f;

    //ī�޶� ����
    public float angleX = 0.0f;    
    public float angleY = 0.0f;    
    public float angleZ = 0.0f;    

    //Ÿ�� ��ġ
    Vector3 TargetPos;

    //ī�޶� �ӵ�
    public float CameraSpeed = 10.0f;

    void Start()
    {
     
    }

    void Update()
    {
        TargetPos = new Vector3(
            Target.transform.position.x + offsetX,
            Target.transform.position.y + offsetY,
            Target.transform.position.z + offsetZ
            );

        transform.rotation = Quaternion.Euler(angleX, angleY, angleZ);
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime*CameraSpeed);
    }
}

/*
 * <<9/4_����>>
 * ���� �ȿ� �� ������ ����. 
 * ���� ������ ����� chase �ϵ��� �ڵ带 ¥����.
 * ...������ǥ�� ���ϰ� �̵��ϴϱ� ������ ����.
 * 
 * +�������� ī�޶� �̴� �������� �����ϱ� ��ƴ�. 
 * �÷��̾�� ���� �ѹ������ Ű���ε� �غ��� �ڴ�.
 */