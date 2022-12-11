using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAround : MonoBehaviour
{
    private int count;
    // Start is called before the first frame update

 /*   void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }

    }*/

    void Start()
    {
        count = 0;
        transform.Translate(new Vector3(0f, 0.5f, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(0.1f, 0f, 0.1f);
        if (count > 50)
        {
            Destroy(gameObject);
            count = 0;
        }
        count++;
    }
}
