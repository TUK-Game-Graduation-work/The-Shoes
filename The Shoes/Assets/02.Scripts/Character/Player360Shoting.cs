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
    //한번에 쏠 수있는 총탄의 개수
    float angle = 360 / oneShoting;
    do
    {
        for (int i = 0; i < oneShoting; i++)
        {
            Debug.Log(i);
            GameObject obj;
            obj = (GameObject)Instantiate(bullet, boss.transform.position, Quaternion.identity);

            //지정위치에 bullet을 생성
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed * Mathf.Cos(Mathf.PI * 2 * i / oneShoting), speed * Mathf.Sin(Mathf.PI * i * 2 / oneShoting)));


            obj.transform.Rotate(new Vector3(0f, 0f, 360 * i / oneShoting - 90));
        }
        //지정해둔 각도의 방향으로 모든 총탄을 날리고, 날아가는 방향으로 방향회전을 해줍니다.

        yield return new WaitForSeconds(1f);
    } while (true);
}
*/
