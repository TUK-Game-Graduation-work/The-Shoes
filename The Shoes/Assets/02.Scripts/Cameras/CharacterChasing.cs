using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChasing : MonoBehaviour
{
    // GameObject player;
    public GameObject Target;

    //카메라 좌표
    public float offsetX = 0.0f;
    public float offsetY = 10.0f;
    public float offsetZ = -10.0f;

    //카메라 각도
    public float angleX = 0.0f;    
    public float angleY = 0.0f;    
    public float angleZ = 0.0f;    

    //타겟 위치
    Vector3 TargetPos;

    //카메라 속도
    public float CameraSpeed = 10.0f;

/*    //화면 정지상태일 때 움직임 폭 설정
    float moveWidth = 3.0f;

    //기초 폭 설정
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

/*      //X 움직임
        if (TargetPos.x >= maxX || TargetPos.x <= minX)
        {
            maxX = TargetPos.x + moveWidth;
            minX = TargetPos.x - moveWidth;
            transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime*CameraSpeed);
        }

        //Z 움직임
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
 * <<9/4_시작>>
 * 범위 안에 만 있으면 고정. 
 * 일정 범위를 벗어나면 chase 하도록 코드를 짜본다.
 * ...지정좌표로 퐛하고 이동하니까 문제가 생김.
 * 
 * +생각보다 카메라를 미는 느낌으로 구현하기 어렵다. 
 * 플레이어와 동일 한방법으로 키맵핑도 해봐야 겠다.
 */