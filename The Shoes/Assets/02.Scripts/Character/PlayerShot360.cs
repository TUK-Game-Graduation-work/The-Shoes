using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot360 : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePos;
    private float count;
    // Update is called once per frame

    void Start() { }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Q");
            Instantiate(Bullet, FirePos.position, Quaternion.identity);
        }
    }
}
