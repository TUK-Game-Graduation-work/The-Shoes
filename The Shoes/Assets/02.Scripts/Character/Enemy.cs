using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHP;
    public int enemyMaxHP;
    public int enemyMinHP;

    //true 생존, false 소멸
    public bool enemyState;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bullet360")
        {
            //나중에 탄환 스크립트에서 변수만들면 바꾸기
            enemyHP -= 2;
        }

    }
    void Start()
    {
        enemyMaxHP = 10;
        enemyHP = enemyMaxHP;
        enemyMinHP = 0;
        enemyState = true;

    }

    void Update()
    {
        if (enemyHP <= enemyMinHP)
        {
            //소멸
            enemyState = false;
            Destroy(gameObject, 0.5f);
        }
    }
}
