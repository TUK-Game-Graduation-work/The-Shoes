using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spine : MonoBehaviour
{
    public GameManager gameManager;
    public bool isCollision = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCollision)
        {
            gameManager.isGameOver = true;
            isCollision = false;
        }
    }
}
