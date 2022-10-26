using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FloatingBoard : MonoBehaviour
{
    void Start()
    {
        float setZ = 3 * Random.Range(0f, 2f) + 23f; //z�� �������� �ޱ�
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
 * 1. ������ ���������ߴ�
 * 2. 5�� �� �ϳ��� �ٷ� ���������ߴ�
 * 3. �������� �ӵ��� ��?
 * 4. �������� ���� ����
 */
/*
 * z���� ������ ���� ���� �������� �޾Ƽ� �ʱ� ��ġ ����. �ʱ� ��ġ �� x, y���� ��� ���� z���� �������� ����.
 * ���� ������ �������� deltaTime�� 4�� �ӵ��� �̵�, ������ ������ �����ϸ� ������Ʈ ����.
 */