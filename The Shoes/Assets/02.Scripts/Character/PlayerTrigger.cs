using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gate")
        {
            LoadingSceneManager.LoadScene("Stage2");
        }

    }
    // Start is called before the first frame update
    void Start()
    {

    }
}
