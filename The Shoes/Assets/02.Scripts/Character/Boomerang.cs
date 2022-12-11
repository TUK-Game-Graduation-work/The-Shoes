using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : MonoBehaviour
{

    GameObject player;
    float delTime;
    public float moveSpeed = 0.5f;
    float playerZpos;
    void Start()
    {
        delTime = 0.0f;
        this.player = GameObject.Find("Player");
    }

    void Update()
    {
        if (player.GetComponent<PlayerMove>().isAttack == true)
        {
            throwBoomerang();
        }
    }
    void throwBoomerang()
    {
        if(delTime == 0.0f) { playerZpos = player.transform.position.z; }

        delTime += Time.deltaTime;

        float goBack = (Mathf.Sin(delTime)) * 5.0f + playerZpos;
        transform.position = new Vector3(transform.position.x, transform.position.y, goBack);

        if(player.transform.position.z >= transform.position.z)
        {
            player.GetComponent<PlayerMove>().isAttack = false;
            delTime = 0.0f;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Àû ´êÀ¸¸é ÇÇ ±ð±â
        }
    }
}
