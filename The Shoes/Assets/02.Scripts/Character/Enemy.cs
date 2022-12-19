using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHP;
    public int enemyMaxHP;
    public int enemyMinHP;

    //true »ýÁ¸, false ¼Ò¸ê
    public bool enemyState;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet360")
        {
            enemyHP -= 20;
        }
        if(other.gameObject.tag == "boomerang")
        {
            enemyHP -= 30;
        }

    }
    void Start()
    {
        enemyMaxHP = 100;
        enemyHP = enemyMaxHP;
        enemyMinHP = 0;
        enemyState = true;

    }

    void Update()
    {
        if (enemyHP <= enemyMinHP)
        {
            //¼Ò¸ê
            enemyState = false;
            Destroy(gameObject, 0.5f);
        }
    }
}
