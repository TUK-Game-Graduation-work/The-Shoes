using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private GameManager CheckManager;
    public bool CheckReach;
    public Vector3 posi;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print("체크포인트 충돌");
            posi = transform.position;
            CheckReach = true;

        }
    }
    void Start()
    {
        //CheckReach = false;
        CheckManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {

    }
}
