using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player360Shoting : MonoBehaviour
{
    public float oneShoting;
  //  public Transform drawSphereObject;

  //  void OnDrawGizmosSelected()
   // {
        //Gizmos.color = Color.red;
        //Gizmos.DrawSphere(drawSphereObject.transform.position, 2f);
   // }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
/*
IEnumerator SpellStart()
{
    //�ѹ��� �� ���ִ� ��ź�� ����
    float angle = 360 / oneShoting;
    do
    {
        for (int i = 0; i < oneShoting; i++)
        {
            Debug.Log(i);
            GameObject obj;
            obj = (GameObject)Instantiate(bullet, boss.transform.position, Quaternion.identity);

            //������ġ�� bullet�� ����
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed * Mathf.Cos(Mathf.PI * 2 * i / oneShoting), speed * Mathf.Sin(Mathf.PI * i * 2 / oneShoting)));


            obj.transform.Rotate(new Vector3(0f, 0f, 360 * i / oneShoting - 90));
        }
        //�����ص� ������ �������� ��� ��ź�� ������, ���ư��� �������� ����ȸ���� ���ݴϴ�.

        yield return new WaitForSeconds(1f);
    } while (true);
}
*/
