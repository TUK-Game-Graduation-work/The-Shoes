using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAround : MonoBehaviour
{
    private int count;
    // Start is called before the first frame update

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }

    }

    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 1f);
        if (count > 10)
            Destroy(gameObject);
        count++;
    }
}
