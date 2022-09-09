using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTree : MonoBehaviour
{
    GameObject player = null;
    Vector3 treeCurPos;

    public float playerDistance = 10.0f;
    public float fallingSpeed = 80.0f;
    public float stopFallingTime = 33.0f;

    float distance = 0.0f;
    float time = 0.0f;

    void Start()
    {
        player = GameObject.Find("Player");
        //player = GameObject.FindGameObjectsWithTag("Player");

        treeCurPos = this.transform.position;
    }

    void Update()
    {
        distance = Vector3.Distance(treeCurPos, player.transform.position);
        if (playerDistance >= distance)
        {
            time += 1;
            //Debug.Log("나무 쓰러짐");
            if (time <= stopFallingTime)
            {
                this.transform.Translate(-1, 0, 0);
                this.transform.Translate(0, -2, 0);
                this.transform.Rotate(Vector3.forward * Time.deltaTime * fallingSpeed);
                this.transform.Translate(0, 2, 0);
                this.transform.Translate(1, 0, 0);
                //Time.timeScale = 0;
            }
        }
    }


}
