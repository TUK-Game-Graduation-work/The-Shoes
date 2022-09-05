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

/*    //ȭ�� ���������� �� ������ �� ����
    float moveWidth = 3.0f;

    //���� �� ����
    float maxX = 3.0f;
    float minX = -3.0f;
    float maxZ = 0.5f;
    float minZ = -5.5f;
*/

    void Start()
    {
     
    }

    void Update()
    {
        TargetPos = new Vector3(
            Target.transform.position.x + offsetX,
            Target.transform.position.y + offsetY,
            Target.transform.position.z + offsetZ);

/*      //X ������
        if (TargetPos.x >= maxX || TargetPos.x <= minX)
        {
            maxX = TargetPos.x + moveWidth;
            minX = TargetPos.x - moveWidth;
            transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime*CameraSpeed);
        }

        //Z ������
        if (TargetPos.z - 2.5f >= maxZ || TargetPos.z - 2.5f <= minZ)
        {
            maxZ = TargetPos.z - 2.5f + moveWidth;
            minZ = TargetPos.z - 2.5f - moveWidth;
            transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime*CameraSpeed);
        }
*/

        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime*CameraSpeed);
        transform.rotation = Quaternion.Euler(angleX, angleY, angleZ);
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