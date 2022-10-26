using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FloatingBoard : MonoBehaviour
{
    void Start()
    {
        float setZ = 3 * Random.Range(0f, 2f) + 23f; //z값 랜덤으로 받기
        transform.position = new Vector3(-40f + Time.deltaTime, 1f, setZ);
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.x >= -56.0f)
        {
            transform.position = new Vector3(transform.position.x - 4 * Time.deltaTime, transform.position.y, transform.position.z);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
/*
 * 1. 나무가 떠내려가야댐
 * 2. 5줄 중 하나의 줄로 떠내려가야댐
 * 3. 내려가는 속도와 빈도?
 * 4. 떠내려간 나무 삭제
 */
/*
 * z값을 정해진 범위 내에 랜덤으로 받아서 초기 위치 설정. 초기 위치 중 x, y값은 모두 같고 z값만 랜덤으로 설정.
 * 물이 끝나는 지점까지 deltaTime의 4배 속도로 이동, 끝나는 지점에 도착하면 오브젝트 삭제.
 */