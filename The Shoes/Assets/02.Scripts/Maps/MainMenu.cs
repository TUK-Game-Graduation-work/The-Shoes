using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class MainMenu : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void OnClickOption()
    {

    }
    public void OnClickExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
