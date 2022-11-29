using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnType : MonoBehaviour
{
    public BTNType currentType;
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BTNType.Start:
                break;
            case BTNType.Option:
                break;
            case BTNType.Back:
                break;
            case BTNType.Sound:
                break;
            case BTNType.Quit:
                break;
        }
    }
}
