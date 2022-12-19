using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : MonoBehaviour
{
    GameObject player;
    public float moveSpeed = 0.5f;
    
    float delTime;
    float playerZpos;
    float playerXpos;

    float goBack;
    void Start()
    {
        delTime = 0.0f;
        this.player = GameObject.Find("Player");
        transform.position = new Vector3(player.transform.position.x, 0.0f, player.transform.position.z);
        
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
        if(delTime == 0.0f) { 
            playerZpos = player.transform.position.z;
            playerXpos = player.transform.position.x;
        }

        delTime += Time.deltaTime;

        if(player.GetComponent<PlayerMove>().inputKey == 'W')
        {
            goBack = (Mathf.Sin(delTime)) * 5.0f + playerZpos;
            transform.position = new Vector3(transform.position.x, transform.position.y, goBack);
            if(player.transform.position.z >= transform.position.z)
            {
                player.GetComponent<PlayerMove>().isAttack = false;
                Destroy(gameObject);
            }
        }
        else if (player.GetComponent<PlayerMove>().inputKey == 'A')
        {
            goBack = (Mathf.Sin(delTime)) * 5.0f + playerXpos;
            transform.position = new Vector3(-goBack, transform.position.y, transform.position.z);
            if (player.transform.position.x <= transform.position.x)
            {
                player.GetComponent<PlayerMove>().isAttack = false;
                Destroy(gameObject);
            }
        }
        else if (player.GetComponent<PlayerMove>().inputKey == 'S')
        {
            goBack = (Mathf.Sin(delTime)) * 5.0f + playerZpos;
            transform.position = new Vector3(transform.position.x, transform.position.y, -goBack);
            if (player.transform.position.z <= transform.position.z)
            {
                player.GetComponent<PlayerMove>().isAttack = false;
                Destroy(gameObject);
            }
        }
        else if (player.GetComponent<PlayerMove>().inputKey == 'D')
        {
            goBack = (Mathf.Sin(delTime)) * 5.0f + playerXpos;
            transform.position = new Vector3(goBack, transform.position.y, transform.position.z);
            if (player.transform.position.x >= transform.position.x)
            {
                player.GetComponent<PlayerMove>().isAttack = false;
                Destroy(gameObject);
            }
        }

    }
}
