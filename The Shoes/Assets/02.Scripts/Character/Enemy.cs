using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHP;
    public int enemyMaxHP;
    public int enemyMinHP;

    //true ����, false �Ҹ�
    public bool enemyState;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet360")
        {
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
            //�Ҹ�
            enemyState = false;
            Destroy(gameObject, 0.5f);
        }
    }
}
