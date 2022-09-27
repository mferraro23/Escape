using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FullScreenToggle : MonoBehaviour
{
    bool typeFS;

    public void HandleInputData(int val)
    {
        if(val == 0)
        {
            typeFS = true;
        }
        else if(val == 1)
        {
            typeFS = false;
        }

        FullScreen();
    }
    public void FullScreen()
    {
        Screen.fullScreen = typeFS;
        Debug.Log(typeFS);

    }
}
